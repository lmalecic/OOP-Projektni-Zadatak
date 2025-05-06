using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class PlayerContainer : UserControl
    {
        public bool IsFavorite { get; set; } = false;
        public Player? SelectedPlayer { get; set; } 

        public PlayerContainer()
        {
            Initialize();
        }

        public void Initialize()
        {
            InitializeComponent();

            if (SelectedPlayer == null)
            {
                lb_Captain.Visible = false;
                lb_Name.Text = "Empty slot";
                lb_Number.Text = "";
                lb_Position.Text = "";
                img_Player.Image = Properties.Resources.PlayerSlot;
                return;
            }

            lb_Name.Text = SelectedPlayer.Name;
            lb_Number.Text = SelectedPlayer.ShirtNumber.ToString();
            lb_Position.Text = SelectedPlayer.Position.ToString();
            lb_Captain.Visible = SelectedPlayer.Captain;
        }

        public void SetPlayer(Player player)
        {

        }
    }
}
