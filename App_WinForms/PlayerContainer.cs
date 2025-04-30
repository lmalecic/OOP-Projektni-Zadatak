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
        private System.Windows.Forms.Timer hoverCheckTimer = new() {
            Interval = 100,
        };

        public PlayerContainer()
        {
            InitializeComponent();
            btn_Favorite.Visible = false;

            hoverCheckTimer.Tick += hoverCheckTimer_Tick;
        }

        public void SetPlayer()
        {

        }

        private void btn_Favorite_MouseEnter(object sender, EventArgs e)
        {
            btn_Favorite.ForeColor = Color.Gold;
        }

        private void btn_Favorite_MouseLeave(object sender, EventArgs e)
        {
            btn_Favorite.ForeColor = Color.Gray;
        }

        private void btn_Favorite_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Favorite.ForeColor = Color.Yellow;
        }

        private void btn_Favorite_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Favorite.ForeColor = Color.Gray;
        }

        private void PlayerContainer_MouseEnter(object sender, EventArgs e)
        {
            btn_Favorite.Visible = true;
            hoverCheckTimer.Start();
        }

        private void hoverCheckTimer_Tick(object sender, EventArgs e)
        {
            var cursorPos = this.PointToClient(Cursor.Position);
            if (!this.ClientRectangle.Contains(cursorPos))
            {
                btn_Favorite.Visible = false;
                hoverCheckTimer.Stop();
            }
        }
    }
}
