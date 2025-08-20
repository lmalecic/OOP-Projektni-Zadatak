using DAL;
using DAL.Enums;
using DAL.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace App_WPF
{
    /// <summary>
    /// Interaction logic for StartupSettings.xaml
    /// </summary>
    public partial class SettingsWindow : Window, INotifyPropertyChanged
    {
        public CultureInfo[] CultureChoices { get; } = [CultureInfo.CurrentCulture, new("hr"), new("en")];
        public TournamentChoice[] TournamentChoices { get; } = Enum.GetValues(typeof(TournamentType))
            .Cast<TournamentType>()
            .Select(val => new TournamentChoice(val, val.ToDisplayString()))
            .ToArray();

        private SizeSetting selectedSize = App.Config.SizeSetting;
        public SizeSetting SelectedSize
        {
            get => selectedSize;
            set
            {
                if (selectedSize != value)
                {
                    selectedSize = value;
                    OnPropertyChanged(nameof(SelectedSize));
                }
            }
        }

        public class TournamentChoice
        {
            public TournamentType Value { get; set; }
            public string DisplayText { get; set; }

            public TournamentChoice(TournamentType tournamentType, string displayText)
            {
                Value = tournamentType;
                DisplayText = displayText;
            }
        }

        private TournamentChoice selectedTournament;
        public TournamentChoice SelectedTournament
        {
            get => selectedTournament;
            set
            {
                if (selectedTournament != value)
                {
                    selectedTournament = value;
                    OnPropertyChanged(nameof(SelectedTournament));
                }
            }
        }

        private CultureInfo selectedCulture = App.Config.Culture;
        public CultureInfo SelectedCulture
        {
            get => selectedCulture;
            set
            {
                if (selectedCulture != value)
                {
                    selectedCulture = value;
                    OnPropertyChanged(nameof(SelectedCulture));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SettingsWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            selectedTournament = TournamentChoices.FirstOrDefault(tC => tC.Value == App.Config.Tournament, TournamentChoices[0]);
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            App.Config.Tournament = SelectedTournament.Value;
            App.Config.Culture = SelectedCulture;
            App.Config.SizeSetting = SelectedSize;

            App.ConfigRepository.Save(App.Config);

            this.Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
