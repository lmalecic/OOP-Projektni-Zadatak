namespace App_WinForms
{
    partial class PlayerContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lb_Name = new Label();
            panel1 = new Panel();
            img_Player = new PictureBox();
            lb_Number = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lb_Position = new Label();
            lb_Captain = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Player).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lb_Name, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(lb_Number, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(140, 185);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Dock = DockStyle.Fill;
            lb_Name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(3, 0);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(134, 20);
            lb_Name.TabIndex = 5;
            lb_Name.Text = "Luka Modrić";
            lb_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(img_Player);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 119);
            panel1.TabIndex = 0;
            // 
            // img_Player
            // 
            img_Player.Dock = DockStyle.Fill;
            img_Player.Image = Properties.Resources.PlayerSlot;
            img_Player.Location = new Point(0, 0);
            img_Player.Margin = new Padding(0);
            img_Player.Name = "img_Player";
            img_Player.Size = new Size(134, 119);
            img_Player.SizeMode = PictureBoxSizeMode.Zoom;
            img_Player.TabIndex = 0;
            img_Player.TabStop = false;
            // 
            // lb_Number
            // 
            lb_Number.Dock = DockStyle.Fill;
            lb_Number.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Number.Location = new Point(3, 20);
            lb_Number.Name = "lb_Number";
            lb_Number.Size = new Size(134, 20);
            lb_Number.TabIndex = 1;
            lb_Number.Text = "10";
            lb_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Controls.Add(lb_Position, 1, 0);
            tableLayoutPanel2.Controls.Add(lb_Captain, 2, 0);
            tableLayoutPanel2.Location = new Point(0, 165);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(140, 20);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // lb_Position
            // 
            lb_Position.Dock = DockStyle.Fill;
            lb_Position.Location = new Point(35, 0);
            lb_Position.Name = "lb_Position";
            lb_Position.Size = new Size(70, 20);
            lb_Position.TabIndex = 5;
            lb_Position.Text = "Veznjak";
            lb_Position.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Captain
            // 
            lb_Captain.AutoSize = true;
            lb_Captain.BackColor = Color.Red;
            lb_Captain.Dock = DockStyle.Fill;
            lb_Captain.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Captain.ForeColor = Color.White;
            lb_Captain.Location = new Point(111, 0);
            lb_Captain.Name = "lb_Captain";
            lb_Captain.Size = new Size(26, 20);
            lb_Captain.TabIndex = 0;
            lb_Captain.Text = "C";
            lb_Captain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerContainer
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "PlayerContainer";
            Padding = new Padding(6);
            Size = new Size(152, 197);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Player).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox img_Player;
        private Label lb_Number;
        private Label lb_Name;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lb_Position;
        private Label lb_Captain;
    }
}
