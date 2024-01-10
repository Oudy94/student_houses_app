using student_houses_app;
using student_houses_app.models;
using student_houses_app.Models;

namespace ProjectGroupApp
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

            Main main = new Main();

            Application.Run(main);
        }
    }
}