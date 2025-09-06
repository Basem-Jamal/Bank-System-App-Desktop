using Bank_System_App;

namespace Bank_System_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AddClient());
        }
    }
}
//new HomeMain("Basem Jamal", 100.00f)
//HomeMain("Admin", 2000, "Admin")