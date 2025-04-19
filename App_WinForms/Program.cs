using DAL;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace App_WinForms
{
    public static class App
    {
        public static IRepository FileRepository { get; } = new FileRepository();
        public static StartupConfig StartupConfig { get; } = FileRepository.LoadConfig();

        public static void SetCulture(CultureInfo culture)
        {
            StartupConfig.Culture = culture;
            Thread.CurrentThread.CurrentCulture = culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = culture; // prijevodi
            Application.CurrentCulture = culture;
        }

        public static Form Initialize()
        {
            SetCulture(StartupConfig.Culture);
            return new MainForm();
        }
    }

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
            Application.Run(App.Initialize());
        }
    }
}