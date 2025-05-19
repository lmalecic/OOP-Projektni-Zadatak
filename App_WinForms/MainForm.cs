using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace App_WinForms
{
    public partial class MainForm : Form
    {
        private Point dragStart = new();

        public MainForm()
        {
            this.Initialize();
        }

        public void Initialize()
        {
            Thread.CurrentThread.CurrentCulture = App.Config.Culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = App.Config.Culture; // prijevodi

            InitializeComponent();

            if (!App.ConfigRepository.Exists()) {
                App.OpenSettings();
            }

            cb_FavoriteTeam.DisplayMember = "DisplayName";
            cb_FavoriteTeam.ValueMember = "Country";

            panel_Players.PlayerContainerAdded += Panel_Players_ContainerAdded;
            panel_Players.PlayerContainerRemoved += Panel_Players_ContainerRemoved;
            panel_FavoritePlayers.PlayerContainerAdded += Panel_FavoritePlayers_ContainerAdded;
            panel_FavoritePlayers.PlayerContainerRemoved += Panel_FavoritePlayers_ContainerRemoved;

            OnTournamentChanged(App.Config.Tournament);
        }

        private void FavoritePlayers_Changed(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action) {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems == null)
                        break;

                    foreach (var player in e.NewItems.Cast<Player>()) {
                        panel_FavoritePlayers.Players.Add(player);
                    }

                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems == null)
                        break;

                    foreach (var player in e.OldItems.Cast<Player>()) {
                        panel_FavoritePlayers.Players.Remove(player);
                    }

                    break;
                case NotifyCollectionChangedAction.Reset:
                    panel_FavoritePlayers.Players.Clear();
                    break;
                default:
                    break;
            }
        }

        private void Players_Changed(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action) {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems == null)
                        break;

                    foreach (var player in e.NewItems.Cast<Player>()) {
                        panel_Players.Players.Add(player);
                    }

                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems == null)
                        break;

                    foreach (var player in e.OldItems.Cast<Player>()) {
                        panel_Players.Players.Remove(player);
                    }

                    break;
                case NotifyCollectionChangedAction.Reset:
                    panel_Players.Players.Clear();
                    break;
                default:
                    break;
            }
        }

        public void Reset()
        {
            this.Controls.Clear();
            this.Initialize();
        }

        private bool IsDragTresholdReached(Point mousePos)
            => Math.Abs(mousePos.X - dragStart.X) + Math.Abs(mousePos.Y - dragStart.Y) > SystemInformation.DragSize.Width;

        private void Panel_FavoritePlayers_ContainerRemoved(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown -= this.Container_MouseDown;
            e.Container.MouseMove -= Panel_FavoritePlayers_ContainerMouseMove;
            e.Container.MouseClick -= this.Container_MouseClick;
        }

        private void Panel_FavoritePlayers_ContainerAdded(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown += this.Container_MouseDown;
            e.Container.MouseMove += this.Panel_FavoritePlayers_ContainerMouseMove;
            e.Container.MouseClick += this.Container_MouseClick;
        }

        private void Container_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is not PlayerContainer container)
                return;

            container.Select();
        }

        private void Container_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.dragStart = e.Location;
            }
        }

        private void Panel_FavoritePlayers_ContainerMouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || IsDragTresholdReached(e.Location) || sender is not PlayerContainer container || container.Player == null)
                return;

            container.DoDragDrop(container, DragDropEffects.Copy);
        }

        private void Panel_Players_ContainerRemoved(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown -= this.Container_MouseDown;
            e.Container.MouseMove -= Panel_Players_ContainerMouseMove;
            e.Container.MouseClick -= this.Container_MouseClick;
        }

        private void Panel_Players_ContainerAdded(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown += this.Container_MouseDown;
            e.Container.MouseMove += Panel_Players_ContainerMouseMove;
            e.Container.MouseClick += this.Container_MouseClick;
        }

        private void Panel_Players_ContainerMouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || IsDragTresholdReached(e.Location) || sender is not PlayerContainer container || container.Player == null)
                return;

            container.DoDragDrop(container, DragDropEffects.Copy);
        }

        private void Panel_Players_ContainerMouseDown(object? sender, MouseEventArgs e)
        {
            if (sender is not PlayerContainer container || container.Player == null)
                return;

            container.Select();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.OpenSettings();
        }

        private void cb_FavoriteTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team? team = cb_FavoriteTeam.SelectedItem as Team;
            if (team != null && team.Equals(App.Config.FavoriteTeam))
                return;

            App.SetFavoriteTeam(team);
        }

        private void panel_Players_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null || e.Data.GetData(typeof(PlayerContainer)) is not PlayerContainer sourceContainer ||
                sourceContainer.Parent?.Parent is not PlayersPanel sourcePanel ||
                sourceContainer.Player == null ||
                sourcePanel != panel_FavoritePlayers) {
                return;
            }

            App.RemoveFavoritePlayer(sourceContainer.Player);
        }

        private void panel_Players_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null || e.Data.GetData(typeof(PlayerContainer)) is not PlayerContainer)
                return;

            e.Effect = DragDropEffects.Copy;
        }

        private void panel_FavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null || e.Data.GetData(typeof(PlayerContainer)) is not PlayerContainer sourceContainer ||
                sourceContainer?.Parent?.Parent is not PlayersPanel sourcePanel ||
                sourceContainer.Player == null ||
                sourcePanel != panel_Players) {
                return;
            }

            App.AddFavoritePlayer(sourceContainer.Player);
        }

        private void panel_FavoritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null || e.Data.GetData(typeof(PlayerContainer)) == null)
                return;

            e.Effect = DragDropEffects.Copy;
        }

        internal async void OnTournamentChanged(TournamentType tournament)
        {
            cb_FavoriteTeam.SelectedItem = null;
            cb_FavoriteTeam.DataSource = await App.WorldCupRepository.GetTeams(App.Config.Tournament);
            cb_FavoriteTeam.SelectedItem = cb_FavoriteTeam.Items.Cast<Team>()
                .FirstOrDefault(team => team.Equals(App.Config.FavoriteTeam));

            OnFavoriteTeamChanged(App.Config.FavoriteTeam);
        }

        internal async void OnFavoriteTeamChanged(Team? team)
        {
            panel_Players.Players.Clear();
            panel_FavoritePlayers.Players.Clear();

            if (team == null)
                return;

            foreach (var player in await App.WorldCupRepository.GetTeamPlayers(App.Config.Tournament, team)) {
                panel_Players.Players.Add(player);
            }

            foreach (var player in App.Config.GetFavoritePlayers()) {
                panel_FavoritePlayers.Players.Add(player);
            }
        }

        internal void OnPlayerFavoriteAdded(Player player)
        {
            panel_FavoritePlayers.Players.Add(player);

            var container = panel_Players.GetPlayerContainer(player);
            if (container != null) {
                container.Favorite = true;
            }
        }

        internal void OnPlayerFavoriteRemoved(Player player)
        {
            panel_FavoritePlayers.Players.Remove(player);

            var container = panel_Players.GetPlayerContainer(player);
            if (container != null) {
                container.Favorite = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using var confirmDialog = new ExitConfirmationForm();
            if (confirmDialog.ShowDialog(this) == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }
    }
}
