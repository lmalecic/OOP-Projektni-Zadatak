using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public void Localize()
        {
            Thread.CurrentThread.CurrentCulture = App.StartupConfig.Culture; // jezik, vrijeme
            Thread.CurrentThread.CurrentUICulture = App.StartupConfig.Culture; // prijevodi
        }

        public void Initialize()
        {
            Localize();
            InitializeComponent();

            if (!App.FileRepository.ConfigExists())
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
