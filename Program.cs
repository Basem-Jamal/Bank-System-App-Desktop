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
            ApplicationConfiguration.Initialize(); // Â–« Ìﬂ›Ì ··‹ DPI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new auth());
 
        }
    }
}
//new HomeMain("Basem Jamal", 100.00f)
//HomeMain("Admin", 2000, "Admin")