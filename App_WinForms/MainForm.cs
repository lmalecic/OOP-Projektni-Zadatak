using System;
using System.Collections.Generic;
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
        private IList<Team> teams = new List<Team>();

        public async void Initialize()
        {
            Thread.CurrentThread.CurrentCulture = App.Config.Culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = App.Config.Culture; // prijevodi

            InitializeComponent();

            if (!App.ConfigRepository.Exists())
            {
                App.OpenSettings();
            }

            teams = await App.WorldCupRepository.GetTeams(App.Config.Tournament);

            cb_FavoriteTeam.DataSource = teams;
            cb_FavoriteTeam.DisplayMember = "DisplayName";
            cb_FavoriteTeam.ValueMember = "Country";
            cb_FavoriteTeam.SelectedItem = cb_FavoriteTeam.Items.Cast<Team>()
                .Where(team => team.Equals(App.Config.FavoriteTeam))
                .FirstOrDefault();

            panel_Players.PlayerContainerAdded += Panel_Players_ContainerAdded;
            panel_Players.PlayerContainerRemoved += Panel_Players_ContainerRemoved;
            panel_FavoritePlayers.PlayerContainerAdded += Panel_FavoritePlayers_ContainerAdded;
            panel_FavoritePlayers.PlayerContainerRemoved += Panel_FavoritePlayers_ContainerRemoved;

            UpdatePlayers();
            UpdateFavoritePlayers();
        }

        private void Panel_FavoritePlayers_ContainerRemoved(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown -= Panel_FavoritePlayers_ContainerMouseDown;
        }

        private void Panel_FavoritePlayers_ContainerAdded(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown += Panel_FavoritePlayers_ContainerMouseDown;
        }

        private void Panel_FavoritePlayers_ContainerMouseDown(object? sender, MouseEventArgs e)
        {
            var container = sender as PlayerContainer;
            if (container == null || container.Player == null)
                return;

            container.DoDragDrop(container, DragDropEffects.Copy);
        }

        private void Panel_Players_ContainerRemoved(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown -= Panel_Players_ContainerMouseDown;
        }

        private void Panel_Players_ContainerAdded(object? sender, PlayerPanelContainerEventArgs e)
        {
            if (e.Container == null)
                return;

            e.Container.MouseDown += Panel_Players_ContainerMouseDown;
        }

        private void Panel_Players_ContainerMouseDown(object? sender, MouseEventArgs e)
        {
            var container = sender as PlayerContainer;
            if (container == null || container.Player == null)
                return;

            container.DoDragDrop(container, DragDropEffects.Copy);
        }

        public MainForm()
        {
            Initialize();
        }

        public void Reset()
        {
            this.Controls.Clear();
            this.Initialize();
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

        public async void UpdatePlayers()
        {
            panel_Players.Players.Clear();

            if (App.Config.FavoriteTeam == null)
                return;

            foreach (var player in await App.WorldCupRepository.GetTeamPlayers(App.Config.Tournament, App.Config.FavoriteTeam))
            {
                panel_Players.Players.Add(player);
            }
        }

        public async void UpdateFavoritePlayers()
        {
            panel_Players.Players.Clear();

            Debug.WriteLine(App.Config.FavoritePlayers.Count);

            if (App.Config.FavoriteTeam == null ||
                App.Config.FavoritePlayers.Count == 0)
                return;

            foreach (var player in await App.WorldCupRepository.GetTeamPlayers(App.Config.Tournament, App.Config.FavoriteTeam))
            {
                panel_Players.Players.Add(player);
            }
        }

        private void panel_Players_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is not PlayerContainer sourceContainer ||
                (e.Data as PlayerContainer)?.Parent is not PlayersPanel sourcePanel ||
                sourceContainer.Player == null ||
                sourcePanel != panel_Players)
            {
                return;
            }

            App.RemoveFavoritePlayer(sourceContainer.Player);
        }

        private void panel_Players_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is not PlayerContainer)
                return;

            e.Effect = DragDropEffects.Copy;
        }

        private void panel_FavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null || e.Data.GetData(typeof(PlayerContainer)) is not PlayerContainer sourceContainer ||
                sourceContainer?.Parent is not PlayersPanel sourcePanel ||
                sourceContainer.Player == null ||
                sourcePanel != panel_Players)
            {
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

        internal void UpdateForm()
        {
            UpdateFavoritePlayers();
            UpdatePlayers();
        }
    }
}
