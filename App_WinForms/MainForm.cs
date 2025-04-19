using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace App_WinForms
{
    public partial class MainForm : Form, IResettableForm
    {
        private Form startupSettingsForm = new StartupSettingsForm();

        public MainForm()
        {
            InitializeComponent();

            if (!App.FileRepository.ConfigExists())
            {
                startupSettingsForm.Show();
            }
        }

        public void Reset()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startupSettingsForm.Show();
        }
    }
}
