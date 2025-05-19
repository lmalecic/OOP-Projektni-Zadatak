namespace App_WinForms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.groupBox1 = new GroupBox();
            this.cb_Tournament = new ComboBox();
            this.groupBox2 = new GroupBox();
            this.cb_Language = new ComboBox();
            this.flowLayoutPanel2 = new FlowLayoutPanel();
            this.btn_Confirm = new Button();
            this.btn_Cancel = new Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Tournament);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cb_Tournament
            // 
            resources.ApplyResources(this.cb_Tournament, "cb_Tournament");
            this.cb_Tournament.FormattingEnabled = true;
            this.cb_Tournament.Name = "cb_Tournament";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Language);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cb_Language
            // 
            resources.ApplyResources(this.cb_Language, "cb_Language");
            this.cb_Language.FormattingEnabled = true;
            this.cb_Language.Name = "cb_Language";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.btn_Confirm);
            this.flowLayoutPanel2.Controls.Add(this.btn_Cancel);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // btn_Confirm
            // 
            resources.ApplyResources(this.btn_Confirm, "btn_Confirm");
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += this.btn_Confirm_Click;
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.CausesValidation = false;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += this.btn_Cancel_Click;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btn_Confirm;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private ComboBox cb_Tournament;
        private GroupBox groupBox2;
        private ComboBox cb_Language;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_Confirm;
        private Button btn_Cancel;
    }
}