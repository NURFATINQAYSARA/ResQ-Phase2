using System.Data;
namespace ResQ
{
    // Jasmine's additions. Uses Meera's actor checks; no schema or startup changes.
    internal static partial class Database
    {
        // Saved activity for one request owned by the signed-in resident only.
        public static DataTable GetResidentRequestActivity(int requestId)
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Resident"]);
            MeeraId(requestId);
            using var cmd = MeeraCommand(conn, null, @"
SELECT s.LogId, s.RequestId, s.NewStatus, s.Note, s.LoggedAt,
       changer.FullName AS ChangedByName
FROM SafetyLog s JOIN Requests r ON r.RequestId = s.RequestId
JOIN Users changer ON changer.UserId = s.ChangedById
WHERE r.ResidentId = $actor AND r.RequestId = $id
ORDER BY s.LoggedAt DESC, s.LogId DESC;",
                ("$actor", actor), ("$id", requestId));
            return MeeraTable(cmd);
        }

        // The signed-in volunteer's own availability, re-read from Users.
        public static bool GetVolunteerAvailability()
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Volunteer"]);
            using var cmd = MeeraCommand(conn, null,
                "SELECT Available FROM Users WHERE UserId = $actor;", ("$actor", actor));
            return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
        }

        public static bool SetVolunteerAvailability(bool available)
        {
            using var conn = Open();
            int actor = MeeraActor(conn, ["Volunteer"]);
            using var cmd = MeeraCommand(conn, null, @"
UPDATE Users SET Available = $available
WHERE UserId = $actor AND Role = 'Volunteer' AND Approved = 1;",
                ("$available", available ? 1 : 0), ("$actor", actor));
            return cmd.ExecuteNonQuery() == 1;
        }
    }
}