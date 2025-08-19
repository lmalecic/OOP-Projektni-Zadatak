using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace App_WinForms
{
    public partial class PlayersPanel : UserControl
    {
        private readonly HashSet<PlayerContainer> selectedContainers = new();

        public IReadOnlyCollection<PlayerContainer> SelectedContainers => selectedContainers;
        public ObservableCollection<Player> Players { get; set; } = new();
        public event EventHandler<PlayerPanelContainerEventArgs>? PlayerContainerAdded;
        public event EventHandler<PlayerPanelContainerEventArgs>? PlayerContainerRemoved;

        public PlayersPanel()
        {
            InitializeComponent();
            Players.CollectionChanged += PlayersChanged;
            App.PlayerImageChanged += PlayerImageChanged;

            AddFavoriteButton.Click += AddFavoriteButton_Click;
            RemoveFavoriteButton.Click += RemoveFavoriteButton_Click;
            ChangePictureButton.Click += ChangePictureButton_Click;
        }

        private void AddFavoriteButton_Click(object? sender, EventArgs e)
        {
            int availableSlots = App.Config.MAX_FAVORITE_PLAYERS - App.Config.GetFavoritePlayers().Count;
            if (availableSlots <= 0)
                return;

            var playersToAdd = selectedContainers
                .Select(c => c.Player)
                .Where(p => p != null && !App.IsPlayerFavorite(p))
                .Distinct()
                .Take(availableSlots)
                .ToList();

            foreach (var p in playersToAdd)
            {
                if (p != null)
                    App.AddFavoritePlayer(p);
            }
        }

        private void RemoveFavoriteButton_Click(object? sender, EventArgs e)
        {
            var playersToRemove = selectedContainers
                .Select(c => c.Player)
                .Where(p => p != null && App.IsPlayerFavorite(p))
                .Distinct()
                .ToList();

            foreach (var p in playersToRemove)
            {
                if (p != null)
                    App.RemoveFavoritePlayer(p);
            }
        }

        private async void ChangePictureButton_Click(object? sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            var result = openFileDialog1.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            var imageBytes = await File.ReadAllBytesAsync(openFileDialog1.FileName);
            var image = imageBytes != null ? Image.FromStream(new MemoryStream(imageBytes)) : Properties.Resources.PlayerSlot;

            foreach (var container in selectedContainers)
            {
                var player = container.Player;
                if (player == null)
                    continue;

                if (imageBytes != null)
                {
                    App.ImageRepository.SavePlayerImage(player, imageBytes);
                }

                container.SetImage(image);
                App.PlayerImageChanged?.Invoke(container, new PlayerImageChangedEventArgs(player, image));
            }
        }

        private void OpenContextMenu(Point _)
        {
            this.ChangePictureButton.Visible = true;

            var selectedWithPlayers = selectedContainers.Where(c => c.Player != null).ToList();
            int availableSlots = App.Config.MAX_FAVORITE_PLAYERS - App.Config.GetFavoritePlayers().Count;
            int nonFavoriteSelectedCount = selectedWithPlayers.Count(c => c.Player != null && !App.IsPlayerFavorite(c.Player!));
            bool anyFavoriteSelected = selectedWithPlayers.Any(c => c.Player != null && App.IsPlayerFavorite(c.Player!));

            this.AddFavoriteButton.Visible = nonFavoriteSelectedCount > 0 && nonFavoriteSelectedCount <= availableSlots;
            this.RemoveFavoriteButton.Visible = anyFavoriteSelected;

            contextMenuStrip.Show(Cursor.Position);
        }

        private void PlayerImageChanged(object? sender, PlayerImageChangedEventArgs e)
        {
            PlayerContainer? playerContainer = this.GetPlayerContainer(e.Player);
            if (playerContainer == null)
                return;

            if (sender == playerContainer)
                return;

            playerContainer.SetImage(e.Image);
        }

        public PlayerContainer? GetPlayerContainer(Player player)
        {
            return panel_Items.Controls.Cast<PlayerContainer>()
                .Where(container => player.Equals(container.Player))
                .FirstOrDefault();
        }

        private void AddPlayerContainer(Player player)
        {
            PlayerContainer playerContainer = new(player);
            panel_Items.Controls.Add(playerContainer);
            PlayerContainerAdded?.Invoke(this, new(playerContainer));

            playerContainer.MouseClick += PlayerContainer_MouseClick;
        }

        private void PlayerContainer_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is not PlayerContainer container) return;

            bool ctrlPressed = (ModifierKeys & Keys.Control) == Keys.Control;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (ctrlPressed)
                    {
                        if (selectedContainers.Contains(container))
                        {
                            DeselectContainer(container);
                        }
                        else
                        {
                            SelectContainer(container, multiSelect: true);
                        }
                    }
                    else
                    {
                        SelectContainer(container, multiSelect: false);
                    }
                    break;

                case MouseButtons.Right:
                    if (!selectedContainers.Contains(container))
                    {
                        SelectContainer(container, multiSelect: false);
                    }

                    OpenContextMenu(e.Location);
                    break;

                default:
                    break;
            }
        }

        private void RemovePlayerContainer(Player player)
        {
            PlayerContainer? playerContainer = panel_Items.Controls.Cast<PlayerContainer>()
                                .Where(container => player.Equals(container.Player))
                                .FirstOrDefault();

            if (playerContainer != null)
            {
                PlayerContainerRemoved?.Invoke(this, new(playerContainer));
                panel_Items.Controls.Remove(playerContainer);
                playerContainer.MouseClick -= PlayerContainer_MouseClick;
            }
        }

        public void SelectContainer(PlayerContainer container, bool multiSelect)
        {
            if (!multiSelect)
            {
                foreach (var c in selectedContainers)
                {
                    c.Selected = false;
                }

                selectedContainers.Clear();
            }

            if (!selectedContainers.Contains(container))
            {
                selectedContainers.Add(container);
                container.Selected = true;
            }
        }

        public void DeselectContainer(PlayerContainer container)
        {
            selectedContainers.Remove(container);
            container.Selected = false;
        }

        public void ClearSelection()
        {
            foreach (var c in selectedContainers)
            {
                c.Selected = false;
            }
            selectedContainers.Clear();
        }

        private void PlayersChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    if (e.NewItems != null)
                    {
                        foreach (var player in e.NewItems.Cast<Player>())
                        {
                            AddPlayerContainer(player);
                        }
                    }

                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    if (e.OldItems != null)
                    {
                        foreach (var player in e.OldItems.Cast<Player>())
                        {
                            RemovePlayerContainer(player);
                        }
                    }

                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    panel_Items.Controls.Clear();

                    foreach (var player in Players)
                    {
                        AddPlayerContainer(player);
                    }

                    break;
                default:
                    break;
            }
        }
    }

    public class PlayerPanelContainerEventArgs : EventArgs
    {
        public PlayerContainer? Container;
        public PlayerPanelContainerEventArgs(PlayerContainer? container) => Container = container;
    }
}
