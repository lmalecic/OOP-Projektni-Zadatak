using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_WPF
{
    /// <summary>
    /// Interaction logic for PlayerContainer.xaml
    /// </summary>
    public partial class PlayerContainer : UserControl, INotifyPropertyChanged
    {
        private Player player = null!;
        public Player Player
        {
            get => player;
            set
            {
                if (player != value)
                {
                    player = value;
                    OnPropertyChanged(nameof(Player));
                }
            }
        }

        private BitmapImage playerImageSource = null!;
        public BitmapImage PlayerImageSource
        {
            get => playerImageSource;
            set
            {
                if (playerImageSource != value)
                {
                    playerImageSource = value;
                    OnPropertyChanged(nameof(PlayerImageSource));
                }
            }
        }

        public PlayerContainer(Player player)
        {
            InitializeComponent();
            this.DataContext = this;

            this.PropertyChanged += PlayerContainer_PropertyChanged;

            Player = player;
        }

        private void PlayerContainer_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Player))
            {
                OnPlayerChanged();
            }
        }

        private async void OnPlayerChanged()
        {
            if (this.Player != null)
            {
                var imageBytes = await App.ImageRepository.LoadPlayerImage(Player);
                BitmapImage image = new BitmapImage();

                if (imageBytes != null)
                {
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        image.BeginInit();
                        image.StreamSource = ms;
                        image.CacheOption = BitmapCacheOption.OnLoad;
                        image.EndInit();
                        image.Freeze();
                    }
                }
                else
                {
                    image = new BitmapImage(new Uri(Constants.DEFAULT_PLAYER_IMAGE_PATH, UriKind.Absolute));
                }

                PlayerImageSource = image;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
