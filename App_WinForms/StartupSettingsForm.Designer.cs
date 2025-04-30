namespace App_WinForms
{
    partial class StartupSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupSettingsForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            cb_Tournament = new ComboBox();
            groupBox2 = new GroupBox();
            cb_Language = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_Confirm = new Button();
            btn_Cancel = new Button();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(cb_Tournament);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // cb_Tournament
            // 
            resources.ApplyResources(cb_Tournament, "cb_Tournament");
            cb_Tournament.FormattingEnabled = true;
            cb_Tournament.Name = "cb_Tournament";
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(cb_Language);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // cb_Language
            // 
            resources.ApplyResources(cb_Language, "cb_Language");
            cb_Language.FormattingEnabled = true;
            cb_Language.Name = "cb_Language";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Controls.Add(btn_Confirm);
            flowLayoutPanel2.Controls.Add(btn_Cancel);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // btn_Confirm
            // 
            resources.ApplyResources(btn_Confirm, "btn_Confirm");
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(btn_Cancel, "btn_Cancel");
            btn_Cancel.CausesValidation = false;
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // StartupSettingsForm
            // 
            AcceptButton = btn_Confirm;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartupSettingsForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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