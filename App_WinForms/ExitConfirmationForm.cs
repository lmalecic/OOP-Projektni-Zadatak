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
    public partial class ExitConfirmationForm : Form
    {
        public ExitConfirmationForm()
        {
            InitializeComponent();

            btn_Cancel.Click += Btn_Cancel_Click;
            btn_Confirm.Click += Btn_Confirm_Click;
        }

        private void Btn_Confirm_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
