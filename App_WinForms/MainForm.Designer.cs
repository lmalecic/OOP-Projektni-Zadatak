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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            cb_FavoriteTeam = new ComboBox();
            groupBox2 = new GroupBox();
            panel_FavoritePlayers = new PlayersPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            panel_Players = new PlayersPanel();
            playerBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel4);
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Controls.Add(groupBox2);
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_FavoriteTeam);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // cb_FavoriteTeam
            // 
            resources.ApplyResources(cb_FavoriteTeam, "cb_FavoriteTeam");
            cb_FavoriteTeam.FormattingEnabled = true;
            cb_FavoriteTeam.Name = "cb_FavoriteTeam";
            cb_FavoriteTeam.Sorted = true;
            cb_FavoriteTeam.SelectionChangeCommitted += cb_FavoriteTeam_SelectionChangeCommitted;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel_FavoritePlayers);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // panel_FavoritePlayers
            // 
            panel_FavoritePlayers.AllowDrop = true;
            panel_FavoritePlayers.BackColor = SystemColors.Window;
            panel_FavoritePlayers.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(panel_FavoritePlayers, "panel_FavoritePlayers");
            panel_FavoritePlayers.Name = "panel_FavoritePlayers";
            panel_FavoritePlayers.DragDrop += panel_FavoritePlayers_DragDrop;
            panel_FavoritePlayers.DragEnter += panel_FavoritePlayers_DragEnter;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(groupBox3);
            resources.ApplyResources(flowLayoutPanel4, "flowLayoutPanel4");
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel_Players);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // panel_Players
            // 
            panel_Players.AllowDrop = true;
            panel_Players.BackColor = SystemColors.Window;
            panel_Players.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(panel_Players, "panel_Players");
            panel_Players.Name = "panel_Players";
            panel_Players.DragDrop += panel_Players_DragDrop;
            panel_Players.DragEnter += panel_Players_DragEnter;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(DAL.Player);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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