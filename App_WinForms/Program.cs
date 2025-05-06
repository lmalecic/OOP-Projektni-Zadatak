using DAL;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;

namespace App_WinForms
{
    public class TournamentChoice(TournamentType value, string description)
    {
        public TournamentType Value { get; } = value;
        public string Description { get; } = description;
    }

    public static class App
    {
        public readonly static IList<CultureInfo> Cultures = [ CultureInfo.CurrentCulture, new("hr"), new("en") ];
        public readonly static IList<TournamentChoice> Tournaments = Enum.GetValues(typeof(TournamentType))
            .Cast<TournamentType>()
            .Select(val => new TournamentChoice(val, EnumHelper.GetDescription(val)))
            .ToList();

        public static IWorldCupRepository WorldCupRepository { get; } = RepositoryFactory.GetWorldCupRepository();
        public static IRepository<Config> ConfigRepository = RepositoryFactory.GetConfigRepository();

        public static Config Config { get; } = ConfigRepository.Get();

        public static Form Initialize()
        {
            SetCulture(Config.Culture);
            return new MainForm();
        }

        public static void Update()
        {
            Application.OpenForms.Cast<IResettableForm>()
                .ToList().ForEach(form => form.Reset());
        }

        public static void SetCulture(CultureInfo culture)
        {
            Application.CurrentCulture = culture;
            Config.Culture = culture;
        }

        public static void SetTournament(TournamentType tournament)
        {
            Config.Tournament = tournament;
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