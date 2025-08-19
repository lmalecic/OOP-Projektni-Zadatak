using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class PlayerContainer : UserControl, IForwardableEventsControl
    {
        public event EventHandler<Player?>? PlayerChanged;
        public event EventHandler<bool>? SelectedChanged;
        public event EventHandler<bool>? FavoriteChanged;

        private bool selected = false;
        public bool Selected
        {
            get => selected;
            set
            {
                selected = value;
                SelectedChanged?.Invoke(this, value);
            }
        }

        private bool favorite = false;
        public bool Favorite
        {
            get => favorite;
            set
            {
                favorite = value;
                FavoriteChanged?.Invoke(this, favorite);
            }
        }

        private Player? player = null;
        public Player? Player
        {
            get => player;
            set
            {
                player = value;
                PlayerChanged?.Invoke(this, player);
            }
        }

        public PlayerContainer()
        {
            InitializeComponent();
            PlayerChanged += OnPlayerChanged;
            FavoriteChanged += OnFavoriteChanged;

            SelectedChanged += PlayerContainer_SelectedChanged;
            ForwardEvents(this);
        }

        private void PlayerContainer_SelectedChanged(object? sender, bool selected)
        {
            this.BackColor = selected == true ? SystemColors.Highlight : SystemColors.Control;
        }

        private void OnFavoriteChanged(object? sender, bool e)
        {
            ico_Favorite.Visible = Favorite;
        }

        public PlayerContainer(Player player) : this()
        {
            this.Player = player;
        }

        private async void OnPlayerChanged(object? sender, Player? player)
        {
            if (player == null)
            {
                this.Selected = false;
                this.Favorite = false;

                lb_Name.Text = "Empty slot";
                lb_Number.Text = "";
                lb_Position.Text = "";

                img_Player.Image = Properties.Resources.PlayerSlot;
                ico_Captain.Visible = false;
                ico_Favorite.Visible = false;

                return;
            }

            this.Selected = false;
            this.Favorite = App.IsPlayerFavorite(player);

            lb_Name.Text = player.ToString();
            lb_Number.Text = player.ShirtNumber.ToString();
            lb_Position.Text = player.Position.ToString();

            ico_Captain.Visible = player.Captain;
            ico_Favorite.Visible = this.Favorite;

            var image = await App.ImageRepository.LoadPlayerImage(player);
            this.SetImage(image != null ? Image.FromStream(new MemoryStream(image)) : Properties.Resources.PlayerSlot);
        }

        public void ForwardEvents(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.MouseDown += (sender, e) => OnMouseDown(e);
                child.MouseMove += (sender, e) => OnMouseMove(e);
                child.MouseClick += (sender, e) => OnMouseClick(e);

                if (child.HasChildren)
                    ForwardEvents(child);
            }
        }

        public void SetImage(Image image)
        {
            img_Player.Image = image;
        }
    }
}
