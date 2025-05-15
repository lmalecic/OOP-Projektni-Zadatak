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
    public partial class PlayersPanel : UserControl, IForwardableEventsControl
    {
        public ObservableCollection<Player> Players { get; set; } = new();

        public event EventHandler<PlayerPanelContainerEventArgs> PlayerContainerAdded;
        public event EventHandler<PlayerPanelContainerEventArgs> PlayerContainerRemoved;

        public PlayersPanel()
        {
            InitializeComponent();
            panel_Items.AllowDrop = this.AllowDrop;
            Players.CollectionChanged += Players_CollectionChanged;
            ForwardEvents(this);
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

        private void ClearPlayerContainers(Player player)
        {
            panel_Items.Controls.Clear();
        }

        private void Players_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
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

        public void ForwardEvents(Control parent)
        {
            panel_Items.DragDrop += (sender, e) => OnDragDrop(e);
            panel_Items.DragEnter += (sender, e) => OnDragEnter(e);
            panel_Items.DragLeave += (sender, e) => OnDragLeave(e);
        }
    }

    public class PlayerPanelContainerEventArgs : EventArgs
    {
        public PlayerContainer? Container;
        public PlayerPanelContainerEventArgs(PlayerContainer? container) => Container = container;
    }
}
