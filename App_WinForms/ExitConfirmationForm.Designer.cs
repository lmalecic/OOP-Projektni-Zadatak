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
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.btn_Confirm = new Button();
            this.btn_Cancel = new Button();
            this.label1 = new Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_Confirm);
            this.flowLayoutPanel1.Controls.Add(this.btn_Cancel);
            this.flowLayoutPanel1.Dock = DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new Point(0, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new Size(238, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.DialogResult = DialogResult.OK;
            this.btn_Confirm.Location = new Point(160, 3);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new Size(75, 23);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Potvrdi";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = DialogResult.Cancel;
            this.btn_Cancel.Location = new Point(79, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Odustani";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = DockStyle.Fill;
            this.label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(238, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jeste li sigurni da želite izaći?";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitConfirmationForm
            // 
            this.AcceptButton = this.btn_Confirm;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new Size(238, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitConfirmationForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Exit";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_Confirm;
        private Button btn_Cancel;
        private Label label1;
    }
}