namespace App_WinForms
{
    partial class ExitConfirmationForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitConfirmationForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_Confirm = new Button();
            btn_Cancel = new Button();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(btn_Confirm);
            flowLayoutPanel1.Controls.Add(btn_Cancel);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btn_Confirm
            // 
            resources.ApplyResources(btn_Confirm, "btn_Confirm");
            btn_Confirm.DialogResult = DialogResult.OK;
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(btn_Cancel, "btn_Cancel");
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // ExitConfirmationForm
            // 
            AcceptButton = btn_Confirm;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExitConfirmationForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_Confirm;
        private Button btn_Cancel;
        private Label label1;
    }
}