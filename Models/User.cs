namespace ResQ
{
    // One row of the Users table.
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Username { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Area { get; set; } = "";
        public string Role { get; set; } = "Resident";        // Resident, Volunteer or Admin
        public string Status { get; set; } = "Standard";      // Standard or Needs Support
        public bool Approved { get; set; } = true;
        public bool Available { get; set; }                   // for volunteers
    }
}