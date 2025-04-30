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
        public void Initialize()
        {
            Thread.CurrentThread.CurrentCulture = App.Config.Culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = App.Config.Culture; // prijevodi

            InitializeComponent();

            if (!App.ConfigRepository.Exists())
            {
                new StartupSettingsForm().Show();
            }
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
            new StartupSettingsForm().Show();
        }
    }
}
