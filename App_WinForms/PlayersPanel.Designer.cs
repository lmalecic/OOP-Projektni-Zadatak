namespace App_WinForms
{
    partial class PlayersPanel
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
            panel_Items = new FlowLayoutPanel();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip = new ContextMenuStrip(components);
            AddFavoriteButton = new ToolStripMenuItem();
            RemoveFavoriteButton = new ToolStripMenuItem();
            ChangePictureButton = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Items
            // 
            panel_Items.AutoScroll = true;
            panel_Items.BackColor = Color.Transparent;
            panel_Items.Dock = DockStyle.Fill;
            panel_Items.Location = new Point(0, 0);
            panel_Items.Margin = new Padding(0);
            panel_Items.Name = "panel_Items";
            panel_Items.Size = new Size(148, 148);
            panel_Items.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
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
            // 
            // RemoveFavoriteButton
            // 
            RemoveFavoriteButton.Image = Properties.Resources.icons8_sad_32;
            RemoveFavoriteButton.Name = "RemoveFavoriteButton";
            RemoveFavoriteButton.Size = new Size(180, 22);
            RemoveFavoriteButton.Text = "Makni iz omiljenih";
            // 
            // ChangePictureButton
            // 
            ChangePictureButton.Image = Properties.Resources.icons8_picture_32;
            ChangePictureButton.Name = "ChangePictureButton";
            ChangePictureButton.Size = new Size(180, 22);
            ChangePictureButton.Text = "Promijeni sliku";
            // 
            // PlayersPanel
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel_Items);
            Name = "PlayersPanel";
            Size = new Size(148, 148);
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Items;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem AddFavoriteButton;
        private ToolStripMenuItem RemoveFavoriteButton;
        private ToolStripMenuItem ChangePictureButton;
    }
}
