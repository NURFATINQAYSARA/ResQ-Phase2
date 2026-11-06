using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ResQ
{
    // Meera's additions. Keep the original Database.cs; do not replace it.
    internal static partial class Database
    {
        // ---------- shared helpers (no schema or startup changes) ----------
        // Re-read Users: a cached Session.Role is not the authority for these methods.
        private static int MeeraActor(
        SqliteConnection conn, string[] roles, SqliteTransaction? transaction = null)
        {
            if (!Session.IsLoggedIn)
                throw new UnauthorizedAccessException("Please sign in first.");
            using var cmd = MeeraCommand(conn, transaction, @"
SELECT Role, Approved FROM Users WHERE UserId = $id;", ("$id", Session.UserId));
            using var reader = cmd.ExecuteReader();
            if (!reader.Read() || reader.GetInt32(1) != 1 ||
            !roles.Contains(reader.GetString(0)))
                throw new UnauthorizedAccessException("This account cannot perform this action.");
            return Session.UserId;
        }
        private static SqliteCommand MeeraCommand(
        SqliteConnection conn, SqliteTransaction? transaction, string sql,
        params (string Name, object? Value)[] values)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = sql;
            foreach (var value in values)
                cmd.Parameters.AddWithValue(value.Name, value.Value ?? DBNull.Value);
            return cmd;
        }
        // DataTable.Load copies the data; the connection is closed before returning.
        private static DataTable MeeraTable(SqliteCommand cmd)
        {
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }
        private static void MeeraValid(string? message)
        {
            if (message != null) throw new ArgumentException(message);
        }
        private static void MeeraId(int id)
        {
            if (id < 1) throw new ArgumentException("Choose a valid record.");
        }
        private static object? MeeraOptional(string? text) =>
        string.IsNullOrWhiteSpace(text) ? null : text.Trim();
        // ---------- request lists: joins deliberately exclude password and salt ----------
        private const string MeeraRequestSelect = @"
SELECT r.*, resident.FullName AS ResidentName, resident.Status AS ResidentStatus,
 resident.Phone AS ResidentPhone, volunteer.FullName AS VolunteerName
FROM Requests r
JOIN Users resident ON resident.UserId = r.ResidentId
LEFT JOIN Users volunteer ON volunteer.UserId = r.VolunteerId ";
        // Approved volunteers see the unassigned queue, highest priority first.
        public static DataTable GetPendingRequests()
        {
            using var conn = Open();
            MeeraActor(conn, ["Volunteer"]);
            using var cmd = MeeraCommand(conn, null, MeeraRequestSelect + @"
WHERE r.RequestStatus = 'Pending' AND r.VolunteerId IS NULL
ORDER BY CASE r.Priority WHEN 'High' THEN 0 WHEN 'Medium' THEN 1 ELSE 2 END,
 r.CreatedAt, r.RequestId;");
            return MeeraTable(cmd);
        }
        // A volunteer sees only requests assigned to that volunteer.
        public static DataTable GetVolunteerTasks()
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Volunteer"]);
            using var cmd = MeeraCommand(conn, null, MeeraRequestSelect + @"
WHERE r.VolunteerId = $actor ORDER BY r.UpdatedAt DESC, r.RequestId DESC;",
            ("$actor", actor));
            return MeeraTable(cmd);
        }
        public static DataTable GetResidentRequests()
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Resident"]);
            using var cmd = MeeraCommand(conn, null, MeeraRequestSelect + @"
WHERE r.ResidentId = $actor ORDER BY r.CreatedAt DESC, r.RequestId DESC;",
            ("$actor", actor));
            return MeeraTable(cmd);
        }
        // ---------- resident request submission ----------
        // The request and its first log row either both commit or both roll back.
        public static long SubmitRequest(
        string helpType, string location, int peopleCount, string? mobility,
        string priority, string? extraInfo)
        {
            using var conn = Open();
            using var transaction = conn.BeginTransaction();
            int actor = MeeraActor(conn, ["Resident"], transaction);
            MeeraValid(Validator.ValidateRequest(
            helpType, location, peopleCount, mobility, priority, extraInfo));
            using var cmd = MeeraCommand(conn, transaction, @"
INSERT INTO Requests(ResidentId, HelpType, Location, PeopleCount, Mobility,
 Priority, ExtraInfo, RequestStatus, UpdatedAt)
VALUES($actor, $help, $location, $people, $mobility, $priority, $extra,
 'Pending', datetime('now','localtime'));
SELECT last_insert_rowid();",
            ("$actor", actor), ("$help", helpType), ("$location", location.Trim()),
            ("$people", peopleCount), ("$mobility", MeeraOptional(mobility)),
            ("$priority", priority), ("$extra", MeeraOptional(extraInfo)));
            long id = Convert.ToInt64(cmd.ExecuteScalar());
            MeeraLog(conn, transaction, id, actor, "Pending", "Request submitted");
            transaction.Commit();
            return id;
        }
        // ---------- resident cancellation ----------
        public static bool CancelRequest(int requestId)
        {
            using var conn = Open();
            using var transaction = conn.BeginTransaction();
            int actor = MeeraActor(conn, ["Resident"], transaction);
            MeeraId(requestId);
            using var cmd = MeeraCommand(conn, transaction, @"
UPDATE Requests SET RequestStatus = 'Cancelled',
 UpdatedAt = datetime('now','localtime')
WHERE RequestId = $id AND ResidentId = $actor
AND RequestStatus = 'Pending' AND VolunteerId IS NULL;",
 ("$id", requestId), ("$actor", actor));
            if (cmd.ExecuteNonQuery() == 0) return false;
            MeeraLog(conn, transaction, requestId, actor, "Cancelled", "Request cancelled");
            transaction.Commit();
            return true;
        }
        // ---------- volunteer accepts and updates assigned tasks ----------
        // The WHERE clause makes double acceptance impossible: only one update can win.
        public static bool AcceptRequest(int requestId)
        {
            using var conn = Open();
            using var transaction = conn.BeginTransaction();
            int actor = MeeraActor(conn, ["Volunteer"], transaction);
            MeeraId(requestId);
            using var cmd = MeeraCommand(conn, transaction, @"
UPDATE Requests SET RequestStatus = 'Accepted', VolunteerId = $actor,
 UpdatedAt = datetime('now','localtime')
WHERE RequestId = $id AND RequestStatus = 'Pending' AND VolunteerId IS NULL;",
            ("$id", requestId), ("$actor", actor));
            if (cmd.ExecuteNonQuery() == 0) return false;
            MeeraLog(conn, transaction, requestId, actor, "Accepted", "Volunteer accepted");
            transaction.Commit();
            return true;
        }
        // Only the assigned volunteer can move one step forward:
        // Accepted -> In Progress -> Safe / Evacuated -> Completed.
        public static bool UpdateRequestStatus(int requestId, string newStatus, string? note)
        {
            using var conn = Open();
            using var transaction = conn.BeginTransaction();
            int actor = MeeraActor(conn, ["Volunteer"], transaction);
            MeeraId(requestId);
            MeeraValid(Validator.ValidateRequestStatus(newStatus, note));
            string previous = newStatus switch
            {
                "In Progress" => "Accepted",
                "Safe / Evacuated" => "In Progress",
                _ => "Safe / Evacuated"
            };
            using var cmd = MeeraCommand(conn, transaction, @"
UPDATE Requests SET RequestStatus = $new, UpdatedAt = datetime('now','localtime')
WHERE RequestId = $id AND VolunteerId = $actor AND RequestStatus = $previous;",
            ("$new", newStatus), ("$id", requestId), ("$actor", actor),
            ("$previous", previous)); 
            if (cmd.ExecuteNonQuery() == 0) return false;
            MeeraLog(conn, transaction, requestId, actor, newStatus, note);
            transaction.Commit();
            return true;
        }
        private static void MeeraLog(
        SqliteConnection conn, SqliteTransaction transaction, long requestId,
        int actor, string status, string? note)
        {
            using var cmd = MeeraCommand(conn, transaction, @"
INSERT INTO SafetyLog(RequestId, ChangedById, NewStatus, Note)
VALUES($id, $actor, $status, $note);",
            ("$id", requestId), ("$actor", actor), ("$status", status),
            ("$note", MeeraOptional(note)));
            cmd.ExecuteNonQuery();
        }
        // ---------- incident reports ----------
        // Residents and volunteers may report. Every new report starts as Pending.
        public static long SubmitIncident(
        string hazardType, string location, string priority, string? description)
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Resident", "Volunteer"]);
            MeeraValid(Validator.ValidateIncident(hazardType, location, priority, description));
            using var cmd = MeeraCommand(conn, null, @"
INSERT INTO Incidents(ReporterId, HazardType, Location, Priority, Description,
 ReviewStatus)
VALUES($actor, $hazard, $location, $priority, $description, 'Pending');
SELECT last_insert_rowid();",
            ("$actor", actor), ("$hazard", hazardType), ("$location", location.Trim()),
            ("$priority", priority), ("$description", MeeraOptional(description)));
            return Convert.ToInt64(cmd.ExecuteScalar());
        }
        // ---------- incident lists and one-time administrator review ----------
        private const string MeeraIncidentSelect = @"
SELECT i.*, reporter.FullName AS ReporterName, reviewer.FullName AS ReviewedByName
FROM Incidents i JOIN Users reporter ON reporter.UserId = i.ReporterId
LEFT JOIN Users reviewer ON reviewer.UserId = i.ReviewedById ";
        public static DataTable GetMyIncidents()
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Resident", "Volunteer"]);
            using var cmd = MeeraCommand(conn, null, MeeraIncidentSelect + @"
WHERE i.ReporterId = $actor ORDER BY i.CreatedAt DESC, i.IncidentId DESC;",
            ("$actor", actor));
            return MeeraTable(cmd);
        }
        public static DataTable GetPendingIncidents()
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            using var cmd = MeeraCommand(conn, null, MeeraIncidentSelect + @"
WHERE i.ReviewStatus = 'Pending'
ORDER BY CASE i.Priority WHEN 'High' THEN 0 WHEN 'Medium' THEN 1 ELSE 2 END,
 i.CreatedAt, i.IncidentId;");
            return MeeraTable(cmd);
        }
        public static bool ReviewIncident(int incidentId, string reviewStatus)
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Admin"]);
            MeeraId(incidentId);
            MeeraValid(Validator.ValidateIncidentReview(reviewStatus));
            using var cmd = MeeraCommand(conn, null, @"
UPDATE Incidents SET ReviewStatus = $status, ReviewedById = $actor
WHERE IncidentId = $id AND ReviewStatus = 'Pending';",
            ("$status", reviewStatus), ("$actor", actor), ("$id", incidentId));
            return cmd.ExecuteNonQuery() == 1;
        }
        // ---------- shelter and emergency directory ----------
        // A blank filter means all. Search is a literal substring, not a LIKE pattern.
        public static DataTable GetDirectoryEntries(string? kind = null, string? search = null)
        {
            using var conn = Open();
            MeeraActor(conn, ["Resident", "Volunteer", "Admin"]);
            kind = kind?.Trim();
            if (!string.IsNullOrEmpty(kind) && kind is not ("Shelter" or "Emergency contact"))
                throw new ArgumentException("Choose Shelter or Emergency contact.");
            string term = search?.Trim() ?? "";
            term = term.Replace("\\", "\\\\").Replace("%", "\\%").Replace("_", "\\_");
            using var cmd = MeeraCommand(conn, null, @"
SELECT EntryId, Name, Kind, Area, Phone, Status FROM DirectoryEntries
WHERE ($kind IS NULL OR Kind = $kind)
 AND (Name LIKE $search ESCAPE '\' OR Area LIKE $search ESCAPE '\')
ORDER BY Kind, Name, EntryId;",
 ("$kind", MeeraOptional(kind)), ("$search", "%" + term + "%"));
            return MeeraTable(cmd);
        }
        public static long AddDirectoryEntry(
        string name, string kind, string area, string phone, string status)
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            MeeraValid(Validator.ValidateDirectoryEntry(name, kind, area, phone, status));
            using var cmd = MeeraCommand(conn, null, @"
INSERT INTO DirectoryEntries(Name, Kind, Area, Phone, Status)
VALUES($name, $kind, $area, $phone, $status);
SELECT last_insert_rowid();",
            ("$name", name.Trim()), ("$kind", kind), ("$area", area.Trim()),
            ("$phone", phone.Trim()), ("$status", status));
            return Convert.ToInt64(cmd.ExecuteScalar());
        }
        public static bool UpdateDirectoryEntry(
        int entryId, string name, string kind, string area, string phone, string status)
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            MeeraId(entryId);
            MeeraValid(Validator.ValidateDirectoryEntry(name, kind, area, phone, status));
            using var cmd = MeeraCommand(conn, null, @"
UPDATE DirectoryEntries SET Name = $name, Kind = $kind, Area = $area,
 Phone = $phone, Status = $status WHERE EntryId = $id;",
            ("$name", name.Trim()), ("$kind", kind), ("$area", area.Trim()),
            ("$phone", phone.Trim()), ("$status", status), ("$id", entryId));
            return cmd.ExecuteNonQuery() == 1;
        }
        public static bool DeleteDirectoryEntry(int entryId)
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            MeeraId(entryId);
            using var cmd = MeeraCommand(conn, null,
            "DELETE FROM DirectoryEntries WHERE EntryId = $id;", ("$id", entryId));
            return cmd.ExecuteNonQuery() == 1;
        }
        // ---------- administrator safety log and request totals ----------
        public static DataTable GetSafetyLog()
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT s.*, actor.FullName AS ChangedByName, resident.FullName AS ResidentName,
 r.HelpType, r.Location
FROM SafetyLog s JOIN Requests r ON r.RequestId = s.RequestId
JOIN Users actor ON actor.UserId = s.ChangedById
JOIN Users resident ON resident.UserId = r.ResidentId
ORDER BY s.LoggedAt DESC, s.LogId DESC;");
            return MeeraTable(cmd);
        }
        // Only populated groups are returned; each category counts Requests, not log rows.
        public static DataTable GetRequestSummary()
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT 'Status' AS Category, RequestStatus AS Label, COUNT(*) AS Total
FROM Requests GROUP BY RequestStatus
UNION ALL
SELECT 'Priority', Priority, COUNT(*) FROM Requests GROUP BY Priority
UNION ALL
SELECT 'HelpType', HelpType, COUNT(*) FROM Requests GROUP BY HelpType
ORDER BY Category, Label;");
            return MeeraTable(cmd);
        }
        // ---------- resident and administrator home cards ----------
        // Active includes Accepted, In Progress and Safe / Evacuated, not Completed.
        public static DataTable GetResidentHomeSummary()
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Resident"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT COUNT(*) AS TotalRequests,
 COUNT(CASE WHEN RequestStatus = 'Pending' THEN 1 END) AS PendingRequests,
 COUNT(CASE WHEN RequestStatus IN ('Accepted','In Progress','Safe / Evacuated')
 THEN 1 END) AS ActiveRequests,
 COUNT(CASE WHEN RequestStatus = 'Completed' THEN 1 END) AS CompletedRequests
FROM Requests WHERE ResidentId = $actor;", ("$actor", actor));
            return MeeraTable(cmd);
        }
        public static DataTable GetAdminHomeSummary()
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT (SELECT COUNT(*) FROM Requests) AS TotalRequests,
 (SELECT COUNT(*) FROM Requests WHERE RequestStatus = 'Pending') AS PendingRequests,
 (SELECT COUNT(*) FROM Incidents WHERE ReviewStatus = 'Pending') AS PendingIncidents,
 (SELECT COUNT(*) FROM Users WHERE Role = 'Volunteer' AND Approved = 0)
 AS PendingVolunteers,
 (SELECT COUNT(*) FROM AreaRisk WHERE RiskLevel = 'High') AS HighRiskAreas;");
            return MeeraTable(cmd);
        }
        // ---------- administrator monitor (read-only) ----------
        public static DataTable GetAllRequests(string? status = null, string? priority = null)
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            status = status?.Trim();
            priority = priority?.Trim();
            if (!string.IsNullOrEmpty(status) && status is not ("Pending" or "Accepted" or
            "In Progress" or "Safe / Evacuated" or "Completed" or "Cancelled"))
                throw new ArgumentException("Choose a valid request status.");
            if (!string.IsNullOrEmpty(priority) && priority is not ("Low" or "Medium" or "High"))
                throw new ArgumentException("Choose Low, Medium or High priority.");
            using var cmd = MeeraCommand(conn, null, MeeraRequestSelect + @"
WHERE ($status IS NULL OR r.RequestStatus = $status)
 AND ($priority IS NULL OR r.Priority = $priority)
ORDER BY r.UpdatedAt DESC, r.RequestId DESC;",
            ("$status", MeeraOptional(status)), ("$priority", MeeraOptional(priority)));
            return MeeraTable(cmd);
        }
        // ---------- administrator volunteer approval (no new UI required) ----------
        public static DataTable GetPendingVolunteers()
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT UserId, FullName, Username, Phone, Area, Role, Status, Approved,
 Available, HelperFilled, CreatedAt
FROM Users WHERE Role = 'Volunteer' AND Approved = 0 ORDER BY CreatedAt, UserId;");
            return MeeraTable(cmd);
        }
        public static bool ApproveVolunteer(int userId)
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            MeeraId(userId);
            using var cmd = MeeraCommand(conn, null, @"
UPDATE Users SET Approved = 1
WHERE UserId = $id AND Role = 'Volunteer' AND Approved = 0;", ("$id", userId));
            return cmd.ExecuteNonQuery() == 1;
        }
        // Administrator edits an existing seeded area; this never inserts a new area.
        public static bool UpdateAreaRisk(string area, string riskLevel, string? note)
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            MeeraValid(Validator.ValidateAreaRisk(area, riskLevel, note));
            using var cmd = MeeraCommand(conn, null, @"
UPDATE AreaRisk SET RiskLevel = $risk, Note = $note,
 UpdatedAt = datetime('now','localtime') WHERE Area = $area;",
            ("$risk", riskLevel), ("$note", MeeraOptional(note)), ("$area", area.Trim()));
            return cmd.ExecuteNonQuery() == 1;
        }
        // ---------- area risk: all signed-in roles can read ----------
        public static DataTable GetAreaRisks()
        {
            using var conn = Open();
            MeeraActor(conn, ["Resident", "Volunteer", "Admin"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT Area, RiskLevel, Note, UpdatedAt FROM AreaRisk
ORDER BY CASE RiskLevel WHEN 'High' THEN 0 WHEN 'Medium' THEN 1 ELSE 2 END, Area;");
            return MeeraTable(cmd);
        }
    }
}
