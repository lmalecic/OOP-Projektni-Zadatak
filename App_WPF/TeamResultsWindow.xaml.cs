using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for TeamResultsWindow.xaml
    /// </summary>
    public partial class TeamResultsWindow : Window, INotifyPropertyChanged
    {
        private TeamResult teamResults;
        public TeamResult TeamResults
        {
            get => teamResults;
            set
            {
                if (teamResults != value)
                {
                    teamResults = value;
                    OnPropertyChanged(nameof(TeamResult));
                }
            }
        }

        public TeamResultsWindow(TeamResult teamResults)
        {
            InitializeComponent();
            this.DataContext = this;
            TeamResults = teamResults;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
