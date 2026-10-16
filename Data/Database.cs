using System.Data;
using Microsoft.Data.Sqlite;

namespace ResQ
{
    // OWNER: Nurfatin (leader). The ONE shared database for the whole app.
    // Do not change the tables without telling Nurfatin. If the tables change, raise SchemaVersion by 1:
    // the app then rebuilds the database by itself, so nobody has to delete resq.db by hand.
    // The file resq.db is made in the bin folder the first time the app runs. Git ignores it.
    internal static class Database
    {
        private const int SchemaVersion = 1;
        private static readonly string DbPath = Path.Combine(AppContext.BaseDirectory, "resq.db");

        // Everyone uses this to talk to the database:  using var conn = Database.Open();
        public static SqliteConnection Open()
        {
            var conn = new SqliteConnection("Data Source=" + DbPath);
            conn.Open();
            Exec(conn, "PRAGMA foreign_keys = ON;");
            return conn;
        }

        // Called once from Program.cs when the app starts.
        public static void Init()
        {
            using var conn = Open();
            long version = Convert.ToInt64(Scalar(conn, "PRAGMA user_version;"));
            if (version == SchemaVersion) return;

            // First run, or the tables changed: start clean.
            DropAllTables(conn);
            CreateTables(conn);
            Exec(conn, "PRAGMA user_version = " + SchemaVersion + ";");
            Seed(conn);
        }

        // ---------- tables ----------
        private static void CreateTables(SqliteConnection conn)
        {
            Exec(conn, @"
CREATE TABLE Users(
    UserId       INTEGER PRIMARY KEY AUTOINCREMENT,
    FullName     TEXT NOT NULL,
    Username     TEXT NOT NULL UNIQUE COLLATE NOCASE,
    PasswordHash TEXT NOT NULL,
    Salt         TEXT NOT NULL,
    Phone        TEXT NOT NULL,
    Area         TEXT NOT NULL,
    Role         TEXT NOT NULL CHECK (Role IN ('Resident','Volunteer','Admin')),
    Status       TEXT NOT NULL DEFAULT 'Standard' CHECK (Status IN ('Standard','Needs Support')),
    Approved     INTEGER NOT NULL DEFAULT 1,
    Available    INTEGER NOT NULL DEFAULT 0,
    HelperFilled INTEGER NOT NULL DEFAULT 0,
    CreatedAt    TEXT NOT NULL DEFAULT (datetime('now','localtime'))
);
CREATE TABLE Requests(
    RequestId     INTEGER PRIMARY KEY AUTOINCREMENT,
    ResidentId    INTEGER NOT NULL REFERENCES Users(UserId),
    HelpType      TEXT NOT NULL CHECK (HelpType IN ('Evacuation','Mobility support','Safety check-in','Supplies')),
    Location      TEXT NOT NULL,
    PeopleCount   INTEGER NOT NULL DEFAULT 1,
    Mobility      TEXT,
    Priority      TEXT NOT NULL CHECK (Priority IN ('Low','Medium','High')),
    ExtraInfo     TEXT,
    RequestStatus TEXT NOT NULL DEFAULT 'Pending'
                  CHECK (RequestStatus IN ('Pending','Accepted','In Progress','Safe / Evacuated','Completed','Cancelled')),
    VolunteerId   INTEGER REFERENCES Users(UserId),
    Verified      INTEGER NOT NULL DEFAULT 0,
    VerifiedBy    INTEGER REFERENCES Users(UserId),
    CreatedAt     TEXT NOT NULL DEFAULT (datetime('now','localtime')),
    UpdatedAt     TEXT NOT NULL DEFAULT (datetime('now','localtime'))
);
CREATE TABLE SafetyLog(
    LogId       INTEGER PRIMARY KEY AUTOINCREMENT,
    RequestId   INTEGER NOT NULL REFERENCES Requests(RequestId),
    ChangedById INTEGER NOT NULL REFERENCES Users(UserId),
    NewStatus   TEXT NOT NULL,
    Note        TEXT,
    LoggedAt    TEXT NOT NULL DEFAULT (datetime('now','localtime'))
);
CREATE TABLE Incidents(
    IncidentId   INTEGER PRIMARY KEY AUTOINCREMENT,
    ReporterId   INTEGER NOT NULL REFERENCES Users(UserId),
    HazardType   TEXT NOT NULL CHECK (HazardType IN ('Fallen tree','Blocked road','Flooding')),
    Location     TEXT NOT NULL,
    Priority     TEXT NOT NULL CHECK (Priority IN ('Low','Medium','High')),
    Description  TEXT,
    ReviewStatus TEXT NOT NULL DEFAULT 'Pending' CHECK (ReviewStatus IN ('Pending','Verified','Rejected')),
    ReviewedById INTEGER REFERENCES Users(UserId),
    CreatedAt    TEXT NOT NULL DEFAULT (datetime('now','localtime'))
);
CREATE TABLE AreaRisk(
    Area      TEXT PRIMARY KEY,
    RiskLevel TEXT NOT NULL CHECK (RiskLevel IN ('Low','Medium','High')),
    Note      TEXT,
    UpdatedAt TEXT NOT NULL DEFAULT (datetime('now','localtime'))
);
CREATE TABLE DirectoryEntries(
    EntryId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name    TEXT NOT NULL,
    Kind    TEXT NOT NULL CHECK (Kind IN ('Shelter','Emergency contact')),
    Area    TEXT NOT NULL,
    Phone   TEXT NOT NULL,
    Status  TEXT NOT NULL CHECK (Status IN ('Open','Closed','Active'))
);
");
        }

        private static void DropAllTables(SqliteConnection conn)
        {
            var names = new List<string>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%';";
                using var reader = cmd.ExecuteReader();
                while (reader.Read()) names.Add(reader.GetString(0));
            }
            Exec(conn, "PRAGMA foreign_keys = OFF;");
            foreach (string name in names)
                Exec(conn, "DROP TABLE IF EXISTS \"" + name + "\";");
            Exec(conn, "PRAGMA foreign_keys = ON;");
        }

        // ---------- demo data ----------
        // Demo accounts:  admin / Admin@123    volunteer1 / Volunteer@123    resident1 / Resident@123
        private static void Seed(SqliteConnection conn)
        {
            InsertUser(conn, "Nurfatin Qaysara", "admin", "Admin@123", "012-3456789", "Taman Melati", "Admin", "Standard", true);
            InsertUser(conn, "Hakim Tan", "volunteer1", "Volunteer@123", "013-2223344", "Taman Melati", "Volunteer", "Standard", true);
            InsertUser(conn, "Aisyah Rahman", "resident1", "Resident@123", "012-3456780", "Taman Melati", "Resident", "Needs Support", true);

            Exec(conn, @"
UPDATE Users SET Available = 1 WHERE Username = 'volunteer1';
INSERT INTO AreaRisk(Area, RiskLevel, Note) VALUES
 ('Taman Melati',   'High',   'Heavy rain expected.'),
 ('Jalan Bunga',    'High',   'River level rising.'),
 ('Lorong Cempaka', 'Medium', 'Watch for road closures.'),
 ('Bandar Utara',   'Low',    'No hazards reported.'),
 ('Kampung Baru',   'Low',    'No hazards reported.');
INSERT INTO DirectoryEntries(Name, Kind, Area, Phone, Status) VALUES
 ('Dewan Komuniti Melati', 'Shelter',           'Taman Melati', '05-2345678', 'Open'),
 ('Dewan Seri Indah',      'Shelter',           'Kampung Baru', '05-2349900', 'Open'),
 ('Dewan Utara',           'Shelter',           'Bandar Utara', '05-2341122', 'Closed'),
 ('Fire and Rescue',       'Emergency contact', 'All areas',    '999',        'Active');
INSERT INTO Requests(ResidentId, HelpType, Location, PeopleCount, Mobility, Priority, ExtraInfo, RequestStatus)
VALUES
 (3, 'Evacuation', 'No. 12, Jalan Melati 3, Taman Melati', 2, 'Walking aid', 'High',
  'Elderly resident living alone. Needs help reaching the shelter.', 'Pending'),
 (3, 'Supplies', 'No. 12, Jalan Melati 3, Taman Melati', 4, NULL, 'Medium',
  'Baby milk and water.', 'Pending');
INSERT INTO SafetyLog(RequestId, ChangedById, NewStatus, Note) VALUES
 (1, 3, 'Pending', 'Request submitted'),
 (2, 3, 'Pending', 'Request submitted');
INSERT INTO Incidents(ReporterId, HazardType, Location, Priority, Description)
VALUES (3, 'Fallen tree', 'Jalan Melati 1, near the junction', 'High', 'A large tree is blocking both lanes.');
");
        }

        private static void InsertUser(SqliteConnection conn, string fullName, string username, string password,
            string phone, string area, string role, string status, bool approved)
        {
            var (hash, salt) = PasswordHelper.Hash(password);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Users(FullName, Username, PasswordHash, Salt, Phone, Area, Role, Status, Approved)
                                VALUES($n, $u, $h, $s, $p, $a, $r, $st, $ap)";
            cmd.Parameters.AddWithValue("$n", fullName);
            cmd.Parameters.AddWithValue("$u", username);
            cmd.Parameters.AddWithValue("$h", hash);
            cmd.Parameters.AddWithValue("$s", salt);
            cmd.Parameters.AddWithValue("$p", phone);
            cmd.Parameters.AddWithValue("$a", area);
            cmd.Parameters.AddWithValue("$r", role);
            cmd.Parameters.AddWithValue("$st", status);
            cmd.Parameters.AddWithValue("$ap", approved ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        // ---------- users (used by Login, Register and Admin home) ----------
        // Returns the user when the username and password are right, otherwise null and a message to show.
        public static User? Authenticate(string username, string password, out string error)
        {
            error = "";
            using var conn = Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT UserId, FullName, Username, PasswordHash, Salt, Phone, Area, Role, Status, Approved, Available
                                FROM Users WHERE Username = $u";
            cmd.Parameters.AddWithValue("$u", username.Trim());
            using var reader = cmd.ExecuteReader();
            if (!reader.Read() || !PasswordHelper.Verify(password, reader.GetString(3), reader.GetString(4)))
            {
                error = "Wrong username or password.";
                return null;
            }
            if (reader.GetInt32(9) == 0)
            {
                error = "Your account is waiting for administrator approval.";
                return null;
            }
            return new User
            {
                Id = reader.GetInt32(0),
                FullName = reader.GetString(1),
                Username = reader.GetString(2),
                Phone = reader.GetString(5),
                Area = reader.GetString(6),
                Role = reader.GetString(7),
                Status = reader.GetString(8),
                Approved = true,
                Available = reader.GetInt32(10) == 1
            };
        }

        public static bool UsernameExists(string username)
        {
            using var conn = Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = $u";
            cmd.Parameters.AddWithValue("$u", username.Trim());
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public static void AddUser(string fullName, string username, string password, string phone, string area,
            string role, string status, bool approved, bool helperFilled)
        {
            var (hash, salt) = PasswordHelper.Hash(password);
            using var conn = Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Users(FullName, Username, PasswordHash, Salt, Phone, Area, Role, Status, Approved, HelperFilled)
                                VALUES($n, $u, $h, $s, $p, $a, $r, $st, $ap, $hf)";
            cmd.Parameters.AddWithValue("$n", fullName.Trim());
            cmd.Parameters.AddWithValue("$u", username.Trim());
            cmd.Parameters.AddWithValue("$h", hash);
            cmd.Parameters.AddWithValue("$s", salt);
            cmd.Parameters.AddWithValue("$p", phone.Trim());
            cmd.Parameters.AddWithValue("$a", area.Trim());
            cmd.Parameters.AddWithValue("$r", role);
            cmd.Parameters.AddWithValue("$st", status);
            cmd.Parameters.AddWithValue("$ap", approved ? 1 : 0);
            cmd.Parameters.AddWithValue("$hf", helperFilled ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        // ---------- small helpers ----------
        private static void Exec(SqliteConnection conn, string sql)
        {
            using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        private static object? Scalar(SqliteConnection conn, string sql)
        {
            using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }
    }
}