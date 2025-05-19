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

            btn_Cancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            btn_Confirm.Click += (s, e) => this.DialogResult = DialogResult.OK;
        }
    }
}
