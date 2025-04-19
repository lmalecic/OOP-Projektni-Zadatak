using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class StartupSettingsForm : Form, IResettableForm
    {
        private void Initialize() {
            InitializeComponent();
            this.FormClosing += StartupSettingsForm_FormClosing;

            btn_Cancel.Enabled = App.FileRepository.ConfigExists();

            // Set ComboBox data sources
            cb_Language.DataSource = App.Cultures;
            cb_Language.DisplayMember = "DisplayName";
            cb_Language.ValueMember = "Name";
            cb_Language.SelectedItem = App.Cultures
                .Where(cult => cult.Name == App.StartupConfig.Culture.Name)
                .FirstOrDefault(App.Cultures[1]);

            cb_Tournament.DataSource = App.Tournaments
                .Select(val => new { Value = val, Description = EnumHelper.GetDescription(val) })
                .ToList();
            cb_Tournament.DisplayMember = "Description";
            cb_Tournament.ValueMember = "Value";
            cb_Tournament.SelectedIndex = App.Tournaments.IndexOf(App.StartupConfig.Tournament);
        }

        public StartupSettingsForm()
        {
            Initialize();
        }

        private void StartupSettingsForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void SetFirstForm()
        {
            this.btn_Cancel.Enabled = false;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                App.FileRepository.SaveConfig(App.StartupConfig);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Tournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.SetTournament((TournamentType)cb_Tournament.SelectedItem);
        }

        private void cb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.SetCulture(cb_Language.SelectedItem as CultureInfo);
        }

        public void Reset()
        {
            this.Controls.Clear();
            this.Initialize();
        }
    }
}
