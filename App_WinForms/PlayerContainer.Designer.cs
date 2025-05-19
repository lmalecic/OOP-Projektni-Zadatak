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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.lb_Position = new Label();
            this.lb_Number = new Label();
            this.panel1 = new Panel();
            this.img_Player = new PictureBox();
            this.panel2 = new Panel();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.lb_Name = new Label();
            this.ico_Favorite = new PictureBox();
            this.ico_Captain = new Label();
            this.contextMenuStrip = new ContextMenuStrip(this.components);
            this.AddFavoriteButton = new ToolStripMenuItem();
            this.RemoveFavoriteButton = new ToolStripMenuItem();
            this.ChangePictureButton = new ToolStripMenuItem();
            this.openFileDialog1 = new OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.img_Player).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ico_Favorite).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Position, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Number, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(6, 6);
            this.tableLayoutPanel1.Margin = new Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new Size(121, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Position
            // 
            this.lb_Position.Dock = DockStyle.Fill;
            this.lb_Position.Location = new Point(3, 149);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new Size(115, 20);
            this.lb_Position.TabIndex = 8;
            this.lb_Position.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Number
            // 
            this.lb_Number.Dock = DockStyle.Fill;
            this.lb_Number.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lb_Number.Location = new Point(3, 129);
            this.lb_Number.Name = "lb_Number";
            this.lb_Number.Size = new Size(115, 20);
            this.lb_Number.TabIndex = 7;
            this.lb_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.img_Player);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(115, 87);
            this.panel1.TabIndex = 0;
            // 
            // img_Player
            // 
            this.img_Player.Dock = DockStyle.Fill;
            this.img_Player.Image = Properties.Resources.PlayerSlot;
            this.img_Player.Location = new Point(0, 0);
            this.img_Player.Margin = new Padding(0);
            this.img_Player.Name = "img_Player";
            this.img_Player.Size = new Size(115, 87);
            this.img_Player.SizeMode = PictureBoxSizeMode.Zoom;
            this.img_Player.TabIndex = 0;
            this.img_Player.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(0, 0);
            this.panel2.Margin = new Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(121, 36);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Controls.Add(this.lb_Name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ico_Favorite, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ico_Captain, 2, 0);
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.Location = new Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new Size(121, 36);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // lb_Name
            // 
            this.lb_Name.Dock = DockStyle.Fill;
            this.lb_Name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lb_Name.Location = new Point(16, 0);
            this.lb_Name.Margin = new Padding(0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new Size(89, 36);
            this.lb_Name.TabIndex = 13;
            this.lb_Name.Text = "Name";
            this.lb_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ico_Favorite
            // 
            this.ico_Favorite.Dock = DockStyle.Fill;
            this.ico_Favorite.Image = Properties.Resources.icons8_favorite_32;
            this.ico_Favorite.Location = new Point(0, 10);
            this.ico_Favorite.Margin = new Padding(0, 10, 0, 10);
            this.ico_Favorite.Name = "ico_Favorite";
            this.ico_Favorite.Size = new Size(16, 16);
            this.ico_Favorite.SizeMode = PictureBoxSizeMode.Zoom;
            this.ico_Favorite.TabIndex = 11;
            this.ico_Favorite.TabStop = false;
            this.ico_Favorite.Visible = false;
            // 
            // ico_Captain
            // 
            this.ico_Captain.BackColor = Color.Red;
            this.ico_Captain.Dock = DockStyle.Fill;
            this.ico_Captain.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ico_Captain.ForeColor = SystemColors.Control;
            this.ico_Captain.Location = new Point(105, 10);
            this.ico_Captain.Margin = new Padding(0, 10, 0, 10);
            this.ico_Captain.Name = "ico_Captain";
            this.ico_Captain.Size = new Size(16, 16);
            this.ico_Captain.TabIndex = 12;
            this.ico_Captain.Text = "C";
            this.ico_Captain.Visible = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new ToolStripItem[] { this.AddFavoriteButton, this.RemoveFavoriteButton, this.ChangePictureButton });
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new Size(172, 70);
            // 
            // AddFavoriteButton
            // 
            this.AddFavoriteButton.Image = Properties.Resources.icons8_favorite_32;
            this.AddFavoriteButton.Name = "AddFavoriteButton";
            this.AddFavoriteButton.Size = new Size(171, 22);
            this.AddFavoriteButton.Text = "Dodaj u omiljene";
            // 
            // RemoveFavoriteButton
            // 
            this.RemoveFavoriteButton.Image = Properties.Resources.icons8_sad_32;
            this.RemoveFavoriteButton.Name = "RemoveFavoriteButton";
            this.RemoveFavoriteButton.Size = new Size(171, 22);
            this.RemoveFavoriteButton.Text = "Makni iz omiljenih";
            // 
            // ChangePictureButton
            // 
            this.ChangePictureButton.Image = Properties.Resources.icons8_picture_32;
            this.ChangePictureButton.Name = "ChangePictureButton";
            this.ChangePictureButton.Size = new Size(171, 22);
            this.ChangePictureButton.Text = "Promijeni sliku";
            this.ChangePictureButton.Click += this.ChangePictureButton_Click;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // PlayerContainer
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlayerContainer";
            this.Padding = new Padding(6);
            this.Size = new Size(133, 181);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.img_Player).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.ico_Favorite).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox img_Player;
        private Label lb_Number;
        private Label lb_Position;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem AddFavoriteButton;
        private ToolStripMenuItem RemoveFavoriteButton;
        private ToolStripMenuItem ChangePictureButton;
        private Panel panel2;
        private Label lb_Name;
        private Label ico_Captain;
        private PictureBox ico_Favorite;
        private TableLayoutPanel tableLayoutPanel2;
        private OpenFileDialog openFileDialog1;
    }
}
