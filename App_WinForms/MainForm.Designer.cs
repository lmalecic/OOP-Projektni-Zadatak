namespace App_WinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.settingsToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1 = new MenuStrip();
            this.splitContainer1 = new SplitContainer();
            this.flowLayoutPanel2 = new FlowLayoutPanel();
            this.groupBox1 = new GroupBox();
            this.cb_FavoriteTeam = new ComboBox();
            this.groupBox2 = new GroupBox();
            this.panel_FavoritePlayers = new PlayersPanel();
            this.flowLayoutPanel4 = new FlowLayoutPanel();
            this.groupBox3 = new GroupBox();
            this.panel_Players = new PlayersPanel();
            this.playerBindingSource = new BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.playerBindingSource).BeginInit();
            this.SuspendLayout();
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += this.settingsToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new Size(20, 20);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem });
            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel4);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_FavoriteTeam);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cb_FavoriteTeam
            // 
            resources.ApplyResources(this.cb_FavoriteTeam, "cb_FavoriteTeam");
            this.cb_FavoriteTeam.FormattingEnabled = true;
            this.cb_FavoriteTeam.Name = "cb_FavoriteTeam";
            this.cb_FavoriteTeam.Sorted = true;
            this.cb_FavoriteTeam.SelectionChangeCommitted += this.cb_FavoriteTeam_SelectionChangeCommitted;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel_FavoritePlayers);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // panel_FavoritePlayers
            // 
            this.panel_FavoritePlayers.AllowDrop = true;
            this.panel_FavoritePlayers.BackColor = SystemColors.Window;
            this.panel_FavoritePlayers.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(this.panel_FavoritePlayers, "panel_FavoritePlayers");
            this.panel_FavoritePlayers.Name = "panel_FavoritePlayers";
            this.panel_FavoritePlayers.DragDrop += this.panel_FavoritePlayers_DragDrop;
            this.panel_FavoritePlayers.DragEnter += this.panel_FavoritePlayers_DragEnter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel_Players);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // panel_Players
            // 
            this.panel_Players.AllowDrop = true;
            this.panel_Players.BackColor = SystemColors.Window;
            this.panel_Players.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(this.panel_Players, "panel_Players");
            this.panel_Players.Name = "panel_Players";
            this.panel_Players.DragDrop += this.panel_Players_DragDrop;
            this.panel_Players.DragEnter += this.panel_Players_DragEnter;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DAL.Player);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.playerBindingSource).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ToolStripMenuItem settingsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox1;
        private ComboBox cb_FavoriteTeam;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel4;
        private PlayersPanel panel_FavoritePlayers;
        private PlayersPanel panel_Players;
        private BindingSource playerBindingSource;
    }
}