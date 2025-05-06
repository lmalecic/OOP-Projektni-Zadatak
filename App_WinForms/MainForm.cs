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
    public partial class MainForm : Form, IResettableForm
    {
        private StartupSettingsForm startupSettingsForm = new();

        private void OpenSettings()
        {
            if (startupSettingsForm.IsDisposed)
            {
                startupSettingsForm = new();
            }

            startupSettingsForm.Focus();
            startupSettingsForm.Show();
        }

        public void Initialize()
        {
            Thread.CurrentThread.CurrentCulture = App.Config.Culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = App.Config.Culture; // prijevodi

            InitializeComponent();

            if (!App.ConfigRepository.Exists())
                OpenSettings();


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

        private void SetFavoriteTeam(Team team)
        {
            App.Config.FavoriteTeam = team;
            p_Players.Controls.Clear();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void cb_FavoriteTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {

            }
        }
    }
}
