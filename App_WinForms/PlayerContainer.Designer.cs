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
            lb_Number = new Label();
            pictureBox1 = new PictureBox();
            lb_Position = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lb_Name = new Label();
            btn_Favorite = new Button();
            lb_Captain = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lb_Position, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(127, 138);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_Number);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 82);
            panel1.TabIndex = 0;
            // 
            // lb_Number
            // 
            lb_Number.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_Number.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Number.Location = new Point(47, 25);
            lb_Number.Name = "lb_Number";
            lb_Number.Size = new Size(27, 23);
            lb_Number.TabIndex = 1;
            lb_Number.Text = "10";
            lb_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.icons8_jersey_96;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Position
            // 
            lb_Position.Dock = DockStyle.Fill;
            lb_Position.Location = new Point(3, 118);
            lb_Position.Name = "lb_Position";
            lb_Position.Size = new Size(121, 20);
            lb_Position.TabIndex = 1;
            lb_Position.Text = "Veznjak";
            lb_Position.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Controls.Add(lb_Name, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_Favorite, 0, 0);
            tableLayoutPanel2.Controls.Add(lb_Captain, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(127, 30);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Dock = DockStyle.Fill;
            lb_Name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(31, 0);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(65, 30);
            lb_Name.TabIndex = 0;
            lb_Name.Text = "Luka Modrić";
            lb_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Favorite
            // 
            btn_Favorite.Dock = DockStyle.Fill;
            btn_Favorite.FlatAppearance.BorderSize = 0;
            btn_Favorite.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Favorite.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Favorite.FlatStyle = FlatStyle.Flat;
            btn_Favorite.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Favorite.ForeColor = SystemColors.ButtonShadow;
            btn_Favorite.Location = new Point(0, 0);
            btn_Favorite.Margin = new Padding(0);
            btn_Favorite.Name = "btn_Favorite";
            btn_Favorite.Size = new Size(28, 30);
            btn_Favorite.TabIndex = 1;
            btn_Favorite.Text = "⭐";
            btn_Favorite.UseVisualStyleBackColor = true;
            // 
            // lb_Captain
            // 
            lb_Captain.BackColor = Color.Red;
            lb_Captain.Dock = DockStyle.Fill;
            lb_Captain.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Captain.ForeColor = Color.White;
            lb_Captain.Location = new Point(102, 0);
            lb_Captain.Name = "lb_Captain";
            lb_Captain.Size = new Size(22, 30);
            lb_Captain.TabIndex = 2;
            lb_Captain.Text = "C";
            lb_Captain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(120, 150);
            Name = "PlayerContainer";
            Padding = new Padding(6);
            Size = new Size(139, 150);
            MouseEnter += PlayerContainer_MouseEnter;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lb_Position;
        private Label lb_Number;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lb_Name;
        private Button btn_Favorite;
        private Label lb_Captain;
    }
}
