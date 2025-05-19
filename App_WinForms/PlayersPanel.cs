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
        public ObservableCollection<Player> Players { get; set; } = new();
        private readonly HashSet<PlayerContainer> selectedContainers = new();

        public IReadOnlyCollection<PlayerContainer> SelectedContainers => selectedContainers;
        public event EventHandler<PlayerPanelContainerEventArgs> PlayerContainerAdded;
        public event EventHandler<PlayerPanelContainerEventArgs> PlayerContainerRemoved;

        public PlayersPanel()
        {
            InitializeComponent();
            Players.CollectionChanged += PlayersChanged;
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
            PlayerContainerAdded.Invoke(this, new(playerContainer));
        }

        private void RemovePlayerContainer(Player player)
        {
            PlayerContainer? playerContainer = panel_Items.Controls.Cast<PlayerContainer>()
                                .Where(container => player.Equals(container.Player))
                                .FirstOrDefault();

            if (playerContainer != null)
            {
                PlayerContainerRemoved.Invoke(this, new(playerContainer));
                panel_Items.Controls.Remove(playerContainer);
            }
        }

        public void SelectContainer(PlayerContainer container, bool multiSelect)
        {
            if (!multiSelect)
            {
                foreach (var c in selectedContainers)
                    c.BackColor = SystemColors.Control;
                selectedContainers.Clear();
            }

            if (!selectedContainers.Contains(container))
            {
                selectedContainers.Add(container);
                container.BackColor = Color.LightBlue;
            }
        }

        public void DeselectContainer(PlayerContainer container)
        {
            if (selectedContainers.Remove(container))
                container.BackColor = SystemColors.Control;
        }

        public void ClearSelection()
        {
            foreach (var c in selectedContainers)
                c.BackColor = SystemColors.Control;
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
