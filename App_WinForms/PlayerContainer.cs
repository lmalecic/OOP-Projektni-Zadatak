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
        private Player? player = null;

        public bool IsFavorite { get; set; } = false;
        public Player? Player
        {
            get => player;
            set
            {
                player = value;
                this.Controls.Clear();
                Initialize();
            }
        }

        public PlayerContainer()
        {
            Initialize();
        }

        public PlayerContainer(Player player)
        {
            this.player = player;
            Initialize();
            ForwardEvents(this);
        }

        private void Initialize()
        {
            InitializeComponent();

            if (Player == null)
            {
                lb_Name.Text = "Empty slot";
                lb_Position.Visible = false;
                lb_Number.Text = "";
                lb_Position.Text = "";
                img_Player.Image = Properties.Resources.PlayerSlot;

                return;
            }

            lb_Name.Text = $"{(Player.Captain ? "[C] " : "")}{Player.Name}";
            lb_Number.Text = Player.ShirtNumber.ToString();
            lb_Position.Text = Player.Position.ToString();
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
    }
}
