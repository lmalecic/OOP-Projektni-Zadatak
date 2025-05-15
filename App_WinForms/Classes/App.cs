using DAL;
using DAL.Extensions;
using System.Globalization;

namespace App_WinForms
{
    public static class App
    {
        public readonly static IList<CultureInfo> Cultures = [ CultureInfo.CurrentCulture, new("hr"), new("en") ];
        public readonly static IList<TournamentChoice> Tournaments = Enum.GetValues(typeof(TournamentType))
            .Cast<TournamentType>()
            .Select(val => new TournamentChoice(val, val.ToDisplayString()))
            .ToList();

        public static IWorldCupRepository WorldCupRepository { get; } = RepositoryFactory.GetWorldCupRepository();
        public static IRepository<Config> ConfigRepository = RepositoryFactory.GetConfigRepository();

        public static Config Config { get; } = ConfigRepository.Get();

        public static MainForm MainForm = new MainForm();
        public static SettingsForm SettingsForm { get; set; } = new SettingsForm();

        public static void Save()
        {
            ConfigRepository.Save(Config);
        }

        public static void Reset()
        {
            MainForm.Reset();
            
        }

        public static void SetCulture(CultureInfo culture)
        {
            Application.CurrentCulture = culture;
            Config.Culture = culture;
        }

        public static void SetTournament(TournamentType tournament)
        {
            Config.Tournament = tournament;
            MainForm.UpdateForm();
        }

        public static void SetFavoriteTeam(Team? team)
        {
            Config.FavoriteTeam = team;
            MainForm.UpdateForm();
        }

        public static void AddFavoritePlayer(Player player)
        {
            if (!Config.FavoritePlayers.Contains(player) || Config.FavoritePlayers.Count < 3)
            {
                Config.FavoritePlayers.Add(player);
            }

            MainForm.UpdateForm();
        }

        public static void RemoveFavoritePlayer(Player player)
        {
            if (Config.FavoritePlayers.Contains(player))
            {
                Config.FavoritePlayers.Remove(player);
            }
            else
            {

            }

            MainForm.UpdateForm();
        }

        public static Form Initialize()
        {
            SetCulture(Config.Culture);
            return MainForm;
        }

        internal static void OpenSettings()
        {
            if (SettingsForm.IsDisposed)
            {
                SettingsForm = new();
            }

            SettingsForm.Focus();
            SettingsForm.Show();
        }
    }
}