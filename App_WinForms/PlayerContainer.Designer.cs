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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lb_Position = new Label();
            lb_Number = new Label();
            panel1 = new Panel();
            img_Player = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lb_Name = new Label();
            ico_Favorite = new PictureBox();
            ico_Captain = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            AddFavoriteButton = new ToolStripMenuItem();
            RemoveFavoriteButton = new ToolStripMenuItem();
            ChangePictureButton = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Player).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ico_Favorite).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lb_Position, 0, 3);
            tableLayoutPanel1.Controls.Add(lb_Number, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(121, 169);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Position
            // 
            lb_Position.Dock = DockStyle.Fill;
            lb_Position.Location = new Point(3, 149);
            lb_Position.Name = "lb_Position";
            lb_Position.Size = new Size(115, 20);
            lb_Position.TabIndex = 8;
            lb_Position.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Number
            // 
            lb_Number.Dock = DockStyle.Fill;
            lb_Number.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Number.Location = new Point(3, 129);
            lb_Number.Name = "lb_Number";
            lb_Number.Size = new Size(115, 20);
            lb_Number.TabIndex = 7;
            lb_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(img_Player);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 87);
            panel1.TabIndex = 0;
            // 
            // img_Player
            // 
            img_Player.Dock = DockStyle.Fill;
            img_Player.Image = Properties.Resources.PlayerSlot;
            img_Player.Location = new Point(0, 0);
            img_Player.Margin = new Padding(0);
            img_Player.Name = "img_Player";
            img_Player.Size = new Size(115, 87);
            img_Player.SizeMode = PictureBoxSizeMode.Zoom;
            img_Player.TabIndex = 0;
            img_Player.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 36);
            panel2.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.Controls.Add(lb_Name, 1, 0);
            tableLayoutPanel2.Controls.Add(ico_Favorite, 0, 0);
            tableLayoutPanel2.Controls.Add(ico_Captain, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(121, 36);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // lb_Name
            // 
            lb_Name.Dock = DockStyle.Fill;
            lb_Name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(16, 0);
            lb_Name.Margin = new Padding(0);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(89, 36);
            lb_Name.TabIndex = 13;
            lb_Name.Text = "Name";
            lb_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ico_Favorite
            // 
            ico_Favorite.Dock = DockStyle.Fill;
            ico_Favorite.Image = Properties.Resources.icons8_favorite_32;
            ico_Favorite.Location = new Point(0, 10);
            ico_Favorite.Margin = new Padding(0, 10, 0, 10);
            ico_Favorite.Name = "ico_Favorite";
            ico_Favorite.Size = new Size(16, 16);
            ico_Favorite.SizeMode = PictureBoxSizeMode.Zoom;
            ico_Favorite.TabIndex = 11;
            ico_Favorite.TabStop = false;
            ico_Favorite.Visible = false;
            // 
            // ico_Captain
            // 
            ico_Captain.BackColor = Color.Red;
            ico_Captain.Dock = DockStyle.Fill;
            ico_Captain.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ico_Captain.ForeColor = SystemColors.Control;
            ico_Captain.Location = new Point(105, 10);
            ico_Captain.Margin = new Padding(0, 10, 0, 10);
            ico_Captain.Name = "ico_Captain";
            ico_Captain.Size = new Size(16, 16);
            ico_Captain.TabIndex = 12;
            ico_Captain.Text = "C";
            ico_Captain.Visible = false;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { AddFavoriteButton, RemoveFavoriteButton, ChangePictureButton });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(181, 92);
            // 
            // AddFavoriteButton
            // 
            AddFavoriteButton.Image = Properties.Resources.icons8_favorite_32;
            AddFavoriteButton.Name = "AddFavoriteButton";
            AddFavoriteButton.Size = new Size(180, 22);
            AddFavoriteButton.Text = "Dodaj u omiljene";
            AddFavoriteButton.Click += AddFavoriteButton_Click;
            // 
            // RemoveFavoriteButton
            // 
            RemoveFavoriteButton.Image = Properties.Resources.icons8_sad_32;
            RemoveFavoriteButton.Name = "RemoveFavoriteButton";
            RemoveFavoriteButton.Size = new Size(180, 22);
            RemoveFavoriteButton.Text = "Makni iz omiljenih";
            RemoveFavoriteButton.Click += RemoveFavoriteButton_Click;
            // 
            // ChangePictureButton
            // 
            ChangePictureButton.Image = Properties.Resources.icons8_picture_32;
            ChangePictureButton.Name = "ChangePictureButton";
            ChangePictureButton.Size = new Size(180, 22);
            ChangePictureButton.Text = "Promijeni sliku";
            ChangePictureButton.Click += ChangePictureButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // PlayerContainer
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "PlayerContainer";
            Padding = new Padding(6);
            Size = new Size(133, 181);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Player).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ico_Favorite).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
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
