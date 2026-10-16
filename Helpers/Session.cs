namespace ResQ
{
    // Remembers who is logged in while the app is running.
    internal static class Session
    {
        public static User? Current { get; private set; }
        public static bool IsLoggedIn => Current != null;
        public static int UserId => Current?.Id ?? 0;
        public static string Role => Current?.Role ?? "";
        public static string FullName => Current?.FullName ?? "";
        public static string Area => Current?.Area ?? "";
        public static string Status => Current?.Status ?? "";
        public static void Start(User user) => Current = user;
        public static void End() => Current = null;
    }
}