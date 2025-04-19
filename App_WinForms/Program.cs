using DAL;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;

namespace App_WinForms
{
    public static class App
    {
        public static IList<CultureInfo> Cultures = [ CultureInfo.CurrentCulture, new("hr"), new("en") ];
        public static IList<TournamentType> Tournaments = Enum.GetValues(typeof(TournamentType)).Cast<TournamentType>().ToList();

        public static IRepository FileRepository { get; } = new FileRepository();
        public static StartupConfig StartupConfig { get; } = FileRepository.LoadConfig();
        
        public static void SetCulture(CultureInfo culture)
        {
            if (culture.Equals(StartupConfig.Culture))
                return;

            StartupConfig.Culture = culture;

            Application.CurrentCulture = culture;
            Thread.CurrentThread.CurrentCulture = culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = culture; // prijevodi

            foreach (IResettableForm form in Application.OpenForms)
            {
                form.Reset();
            }
        }

        public static Form Initialize()
        {
            SetCulture(StartupConfig.Culture);
            return new MainForm();
        }
        
        internal static void SetTournament(TournamentType tournament)
        {
            if (tournament.Equals(StartupConfig.Tournament))
                return;

            StartupConfig.Tournament = tournament;
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