using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DAL;

namespace App_WPF
{
    /// <summary>
    /// Interaction logic for StartupSettings.xaml
    /// </summary>
    public partial class StartupSettings : Window
    {
        private IRepository<Config> configRepository = RepositoryFactory.GetConfigRepository();

        private TournamentType[] tournaments = {
            TournamentType.Men,
            TournamentType.Women
        };

        public StartupSettings()
        {
            InitializeComponent();

            TournamentType configTournament = configRepository.Exists() ? configRepository.Get().Tournament : tournaments[0];

            TournamentComboBox.ItemsSource = tournaments;
            TournamentComboBox.SelectedItem = configTournament;
        }
    }
}
