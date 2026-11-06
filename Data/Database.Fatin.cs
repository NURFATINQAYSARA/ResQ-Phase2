using System.Data;
using Microsoft.Data.Sqlite;

namespace ResQ
{
    // Fatin's Request Monitor actions. Add beside Database.cs and Database.Meera.cs.
    internal static partial class Database
    {
        public static DataTable GetAssignableVolunteers()
        {
            using var conn = Open();
            MeeraActor(conn, ["Admin"]);
            using var cmd = MeeraCommand(conn, null, @"
SELECT UserId, FullName, Area, Available FROM Users
WHERE Role='Volunteer' AND Approved=1 ORDER BY FullName, UserId;");
            return MeeraTable(cmd);
        }

        // Assign only an unassigned Pending request to an approved volunteer.
        public static bool AssignVolunteer(int requestId, int volunteerId)
        {
            using var conn = Open();
            using var tx = conn.BeginTransaction();
            int actor = MeeraActor(conn, ["Admin"], tx);
            MeeraId(requestId);
            MeeraId(volunteerId);
            using var cmd = MeeraCommand(conn, tx, @"
UPDATE Requests SET VolunteerId=$volunteer, RequestStatus='Accepted',
    UpdatedAt=datetime('now','localtime')
WHERE RequestId=$id AND RequestStatus='Pending' AND VolunteerId IS NULL
    AND EXISTS(SELECT 1 FROM Users WHERE UserId=$volunteer
        AND Role='Volunteer' AND Approved=1);",
                ("$volunteer", volunteerId), ("$id", requestId));
            if (cmd.ExecuteNonQuery() != 1) return false;
            MeeraLog(conn, tx, requestId, actor, "Accepted", "Admin assigned volunteer");
            tx.Commit();
            return true;
        }

        // Verification does not change Completed to a new unsupported status.
        public static bool VerifyCompletion(int requestId)
        {
            using var conn = Open();
            using var tx = conn.BeginTransaction();
            int actor = MeeraActor(conn, ["Admin"], tx);
            MeeraId(requestId);
            using var cmd = MeeraCommand(conn, tx, @"
UPDATE Requests SET Verified=1, VerifiedBy=$actor,
    UpdatedAt=datetime('now','localtime')
WHERE RequestId=$id AND RequestStatus='Completed' AND Verified=0;",
                ("$actor", actor), ("$id", requestId));
            if (cmd.ExecuteNonQuery() != 1) return false;
            MeeraLog(conn, tx, requestId, actor, "Completed", "Admin verified completion");
            tx.Commit();
            return true;
        }
    }
}