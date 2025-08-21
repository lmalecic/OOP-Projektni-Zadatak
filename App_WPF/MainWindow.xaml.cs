using DAL;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private IList<Team> teams1 = [];
        public IList<Team> Teams1
        {
            get => teams1;
            set
            {
                if (teams1 != value)
                {
                    teams1 = value;
                    OnPropertyChanged(nameof(Teams1));
                }
            }
        }

        private IList<Match.MatchTeam> teams2 = [];
        public IList<Match.MatchTeam> Teams2
        {
            get => teams2;
            set
            {
                if (teams2 != value)
                {
                    teams2 = value;
                    OnPropertyChanged(nameof(Teams2));
                }
            }
        }

        private Team? team1;
        public Team? Team1
        {
            get => team1;
            set
            {
                if (team1 != value)
                {
                    team1 = value;
                    OnPropertyChanged(nameof(Team1));
                }
            }
        }

        private Match.MatchTeam? team2;
        public Match.MatchTeam? Team2
        {
            get => team2;
            set
            {
                if (team2 != value)
                {
                    team2 = value;
                    OnPropertyChanged(nameof(Team2));
                }
            }
        }

        private IList<Match> team1Matches = [];
        private Match? selectedMatch;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            loadTeams1();

            PropertyChanged += MainWindow_PropertyChanged;
        }

        private void MainWindow_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Team1))
            {
                App.Config.FavoriteTeam = Team1;
                team1StatsButton.IsEnabled = Team1 != null;
                loadTeams2();
            }
            else if (e.PropertyName == nameof(Team2))
            {
                team2StatsButton.IsEnabled = Team2 != null;
                loadMatch();
            }
        }

        private void loadMatch()
        {
            selectedMatch = team1Matches
                .FirstOrDefault(m => (m.HomeTeam.Equals(team1) && m.AwayTeam.Equals(team2)) ||
                                     (m.AwayTeam.Equals(team1) && m.HomeTeam.Equals(team2)));
            if (selectedMatch == null)
            {
                matchResultPanel.Visibility = Visibility.Hidden;
                return;
            }

            var firstTeam = selectedMatch.HomeTeam.Equals(team1) ? selectedMatch.HomeTeam : selectedMatch.AwayTeam;
            var secondTeam = selectedMatch.HomeTeam.Equals(team1) ? selectedMatch.AwayTeam : selectedMatch.HomeTeam;

            var firstTeamStatistics = selectedMatch.HomeTeam.Equals(team1) ? selectedMatch.HomeTeamStatistics : selectedMatch.AwayTeamStatistics;
            var secondTeamStatistics = selectedMatch.HomeTeam.Equals(team1) ? selectedMatch.AwayTeamStatistics : selectedMatch.HomeTeamStatistics;

            matchResultLabel.Content = $"{firstTeam.Goals} : {secondTeam.Goals}";
            matchResultPanel.Visibility = Visibility.Visible;

            Forward1.Children.Clear();
            Forward2.Children.Clear();
            Midfield1.Children.Clear();
            Midfield2.Children.Clear();
            Defenders1.Children.Clear();
            Defenders2.Children.Clear();
            Goalie1.Children.Clear();
            Goalie2.Children.Clear();

            foreach (var player in firstTeamStatistics.StartingEleven)
            {
                switch (player.Position)
                {
                    case Position.Defender:
                        loadPlayer(Defenders1, player);
                        break;
                    case Position.Forward:
                        loadPlayer(Forward1, player);
                        break;
                    case Position.Goalie:
                        loadPlayer(Goalie1, player);
                        break;
                    case Position.Midfield:
                        loadPlayer(Midfield1, player);
                        break;
                    default:
                        break;
                }
            }

            foreach (var player in secondTeamStatistics.StartingEleven)
            {
                switch (player.Position)
                {
                    case Position.Defender:
                        loadPlayer(Defenders2, player);
                        break;
                    case Position.Forward:
                        loadPlayer(Forward2, player);
                        break;
                    case Position.Goalie:
                        loadPlayer(Goalie2, player);
                        break;
                    case Position.Midfield:
                        loadPlayer(Midfield2, player);
                        break;
                    default:
                        break;
                }
            }
        }

        private void loadPlayer(Panel parent, Player player)
        {
            PlayerContainer playerContainer = new(player);
            parent.Children.Add(playerContainer);
        }

        private async void loadTeams2()
        {
            if (Team1 == null)
            {
                this.Teams2 = [];
                this.teams2ComboBox.IsEnabled = false;
                return;
            }

            team1Matches = await App.WorldCupRepository.GetMatchesByFifaCode(App.Config.Tournament, Team1.FifaCode);

            var availableTeams = team1Matches
                .Select(m => m.HomeTeam.Equals(team1) ? m.AwayTeam : m.HomeTeam)
                //.Distinct()
                .ToList();

            this.Teams2 = availableTeams;
            this.teams2ComboBox.IsEnabled = true;
        }

        private async void loadTeams1()
        {
            this.Teams1 = await App.WorldCupRepository.GetTeams(App.Config.Tournament);
            this.Team1 = App.Config.FavoriteTeam ?? teams1.First();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new();
            settingsWindow.Owner = this;
            settingsWindow.ShowDialog();
        }

        private async void team1StatsButton_Click(object sender, RoutedEventArgs e)
        {
            if (Team1 == null)
            {
                MessageBox.Show("Please select a team first.", "Statistics", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            await showTeamStats(Team1.FifaCode);
        }

        private async void team2StatsButton_Click(object sender, RoutedEventArgs e)
        {
            if (Team2 == null)
            {
                MessageBox.Show("Please select a team first.", "Statistics", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            await showTeamStats(Team2.Code);
        }

        private async Task showTeamStats(string fifaCode)
        {
            var teamStats = await App.WorldCupRepository.GetTeamResultsFor(App.Config.Tournament, fifaCode);
            if (teamStats == null)
            {
                MessageBox.Show("No statistics available for this team.", "Statistics", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            TeamResultsWindow teamResultsWindow = new(teamStats);
            teamResultsWindow.Owner = this;
            teamResultsWindow.ShowDialog();
        }
    }
}