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
            panel1 = new Panel();
            lb_Captain = new Label();
            lb_Name = new Label();
            btn_Favorite = new Button();
            lb_Number = new Label();
            pictureBox1 = new PictureBox();
            lb_Position = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(lb_Position, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(128, 128);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_Captain);
            panel1.Controls.Add(lb_Name);
            panel1.Controls.Add(btn_Favorite);
            panel1.Controls.Add(lb_Number);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 108);
            panel1.TabIndex = 0;
            // 
            // lb_Captain
            // 
            lb_Captain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lb_Captain.BackColor = Color.Red;
            lb_Captain.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Captain.ForeColor = Color.White;
            lb_Captain.Location = new Point(100, 0);
            lb_Captain.Name = "lb_Captain";
            lb_Captain.Size = new Size(28, 28);
            lb_Captain.TabIndex = 3;
            lb_Captain.Text = "C";
            lb_Captain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Name
            // 
            lb_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(19, 32);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(90, 20);
            lb_Name.TabIndex = 2;
            lb_Name.Text = "Luka Modrić";
            lb_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Favorite
            // 
            btn_Favorite.FlatAppearance.BorderSize = 0;
            btn_Favorite.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Favorite.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Favorite.FlatStyle = FlatStyle.Flat;
            btn_Favorite.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Favorite.ForeColor = SystemColors.GrayText;
            btn_Favorite.Location = new Point(0, 0);
            btn_Favorite.Margin = new Padding(0);
            btn_Favorite.Name = "btn_Favorite";
            btn_Favorite.Size = new Size(28, 28);
            btn_Favorite.TabIndex = 0;
            btn_Favorite.Text = "⭐";
            btn_Favorite.UseVisualStyleBackColor = true;
            btn_Favorite.MouseDown += btn_Favorite_MouseDown;
            btn_Favorite.MouseEnter += btn_Favorite_MouseEnter;
            btn_Favorite.MouseLeave += btn_Favorite_MouseLeave;
            btn_Favorite.MouseHover += btn_Favorite_MouseEnter;
            btn_Favorite.MouseUp += btn_Favorite_MouseUp;
            // 
            // lb_Number
            // 
            lb_Number.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_Number.BackColor = Color.FromArgb(64, 64, 64);
            lb_Number.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Number.ForeColor = Color.White;
            lb_Number.Location = new Point(48, 55);
            lb_Number.Name = "lb_Number";
            lb_Number.Size = new Size(32, 23);
            lb_Number.TabIndex = 1;
            lb_Number.Text = "99";
            lb_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.icons8_jersey_96;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Position
            // 
            lb_Position.AutoSize = true;
            lb_Position.Dock = DockStyle.Fill;
            lb_Position.Location = new Point(3, 108);
            lb_Position.Name = "lb_Position";
            lb_Position.Size = new Size(122, 20);
            lb_Position.TabIndex = 2;
            lb_Position.Text = "Position";
            lb_Position.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "PlayerContainer";
            Size = new Size(134, 134);
            MouseEnter += PlayerContainer_MouseEnter;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_Favorite;
        private Label lb_Name;
        private Label lb_Number;
        private Label lb_Position;
        private Label lb_Captain;
    }
}
