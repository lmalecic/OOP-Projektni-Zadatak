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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class SettingsForm : Form
    {
        private SettingsForm()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            btn_Cancel.Enabled = App.ConfigRepository.Exists();

            // Set ComboBox data sources
            cb_Language.DataSource = App.Cultures;
            cb_Language.DisplayMember = "DisplayName";
            cb_Language.ValueMember = "Name";
            cb_Language.SelectedItem = App.Cultures
                .FirstOrDefault(cult => cult.Name.Equals(App.Config.Culture.Name))
                ?? App.Cultures[0];

            cb_Tournament.DataSource = App.Tournaments;
            cb_Tournament.DisplayMember = "DisplayText";
            cb_Tournament.ValueMember = "Value";
            cb_Tournament.SelectedItem = App.Tournaments
                .FirstOrDefault(trnmt => trnmt.Value.Equals(App.Config.Tournament))
                ?? App.Tournaments[0];
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                App.SetCulture(cb_Language.SelectedItem as CultureInfo ?? App.Cultures[0]);
                App.SetTournament((cb_Tournament.SelectedItem as TournamentChoice ?? App.Tournaments[0]).Value);
                App.ConfigRepository.Save(App.Config);
                this.Close();
                App.Reset();
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

        public void Reset()
        {
            this.Controls.Clear();
            this.Initialize();
        }

        public static void Open()
        {
            var settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                App.ConfigRepository.Save(App.Config);
                App.Reset();
            }
        }
    }
}
