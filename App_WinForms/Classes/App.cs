using DAL;
using DAL.Extensions;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace App_WinForms
{
    internal static class App
    {
        public readonly static IList<CultureInfo> Cultures = [CultureInfo.CurrentCulture, new("hr"), new("en")];
        public readonly static IList<TournamentChoice> Tournaments = Enum.GetValues(typeof(TournamentType))
            .Cast<TournamentType>()
            .Select(val => new TournamentChoice(val, val.ToDisplayString()))
            .ToList();

        public static readonly IWorldCupRepository WorldCupRepository = RepositoryFactory.GetWorldCupRepository();
        public static readonly IRepository<Config> ConfigRepository = RepositoryFactory.GetConfigRepository();
        public static readonly ImageRepository ImageRepository = RepositoryFactory.GetImageRepository();
        
        public static Config Config { get; private set; } = ConfigRepository.Get();

        public static MainForm MainForm { get; private set; } = new();
        public static SettingsForm SettingsForm { get; private set; } = new();

        public static async void Initialize()
        {
            SetCulture(Config.Culture);
        }

        public static void Save()
        {
            ConfigRepository.Save(Config);
        }

        public static void Reset()
        {
            MainForm.Reset();
        }

        public static void OpenSettings()
        {
            using var settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK) {
                ConfigRepository.Save(Config);
                Reset();
            }
            //if (SettingsForm == null || SettingsForm.IsDisposed) {
            //    SettingsForm = new();
            //}

            //SettingsForm.Focus();
            //SettingsForm.Show();
        }

        public static void SetCulture(CultureInfo culture)
        {
            Application.CurrentCulture = culture;
            Config.Culture = culture;
        }

        public static void SetTournament(TournamentType tournament)
        {
            Config.Tournament = tournament;
            MainForm.OnTournamentChanged(tournament);
        }

        public static void SetFavoriteTeam(Team? team)
        {
            Config.FavoriteTeam = team;
            MainForm.OnFavoriteTeamChanged(team);
        }

        public static void AddFavoritePlayer(Player player)
        {
            try {
                Config.AddFavoritePlayer(player);
                MainForm.OnPlayerFavoriteAdded(player);
            }
            catch (AlreadyFavoriteException) {
                MessageBox.Show("Player is already favorited!", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (MaxPlayersFavoritedException) {
                MessageBox.Show("You can only add to favorites up to 3 players maximum!", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void RemoveFavoritePlayer(Player player)
        {
            Config.RemoveFavoritePlayer(player);
            MainForm.OnPlayerFavoriteRemoved(player);
        }

        public static bool IsPlayerFavorite(Player player)
            => Config.GetFavoritePlayers().Contains(player);

        static App()
        {
            Initialize();
        }
    }
}