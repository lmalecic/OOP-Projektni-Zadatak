using DAL;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
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

        private IList<Team> teams2 = [];
        public IList<Team> Teams2
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

        private Team team1;
        public Team Team1
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

        private Team team2;
        public Team Team2
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            loadData();
        }

        private async void loadData()
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
    }
}