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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            cb_FavoriteTeam = new ComboBox();
            groupBox2 = new GroupBox();
            p_FavoritePlayers = new FlowLayoutPanel();
            favPlayerSlot1 = new PlayerContainer();
            favPlayerSlot2 = new PlayerContainer();
            favPlayerSlot3 = new PlayerContainer();
            flowLayoutPanel4 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            p_Players = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            p_FavoritePlayers.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
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
            cb_FavoriteTeam.SelectedIndexChanged += cb_FavoriteTeam_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(p_FavoritePlayers);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // p_FavoritePlayers
            // 
            p_FavoritePlayers.BackColor = SystemColors.Window;
            p_FavoritePlayers.BorderStyle = BorderStyle.FixedSingle;
            p_FavoritePlayers.Controls.Add(favPlayerSlot1);
            p_FavoritePlayers.Controls.Add(favPlayerSlot2);
            p_FavoritePlayers.Controls.Add(favPlayerSlot3);
            resources.ApplyResources(p_FavoritePlayers, "p_FavoritePlayers");
            p_FavoritePlayers.Name = "p_FavoritePlayers";
            // 
            // favPlayerSlot1
            // 
            favPlayerSlot1.IsFavorite = false;
            resources.ApplyResources(favPlayerSlot1, "favPlayerSlot1");
            favPlayerSlot1.Name = "favPlayerSlot1";
            favPlayerSlot1.SelectedPlayer = null;
            // 
            // favPlayerSlot2
            // 
            favPlayerSlot2.IsFavorite = false;
            resources.ApplyResources(favPlayerSlot2, "favPlayerSlot2");
            favPlayerSlot2.Name = "favPlayerSlot2";
            favPlayerSlot2.SelectedPlayer = null;
            // 
            // favPlayerSlot3
            // 
            favPlayerSlot3.IsFavorite = false;
            resources.ApplyResources(favPlayerSlot3, "favPlayerSlot3");
            favPlayerSlot3.Name = "favPlayerSlot3";
            favPlayerSlot3.SelectedPlayer = null;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(groupBox3);
            resources.ApplyResources(flowLayoutPanel4, "flowLayoutPanel4");
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(p_Players);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // p_Players
            // 
            p_Players.BackColor = SystemColors.Window;
            p_Players.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(p_Players, "p_Players");
            p_Players.Name = "p_Players";
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
            p_FavoritePlayers.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private FlowLayoutPanel p_FavoritePlayers;
        private GroupBox groupBox3;
        private FlowLayoutPanel p_Players;
        private FlowLayoutPanel flowLayoutPanel4;
        private PlayerContainer favPlayerSlot1;
        private PlayerContainer favPlayerSlot2;
        private PlayerContainer favPlayerSlot3;
    }
}