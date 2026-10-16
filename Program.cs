namespace ResQ
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Database.Init();
            Application.Run(new ResQ.Forms.LoginForm());
        }
    }
}