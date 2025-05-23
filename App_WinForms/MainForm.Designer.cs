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
            panel_FavoritePlayers = new PlayersPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_RankedListPlayers = new Button();
            btn_RankedListImpressions = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            panel_Players = new PlayersPanel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
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
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_RankedListPlayers);
            flowLayoutPanel1.Controls.Add(btn_RankedListImpressions);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btn_RankedListPlayers
            // 
            resources.ApplyResources(btn_RankedListPlayers, "btn_RankedListPlayers");
            btn_RankedListPlayers.Name = "btn_RankedListPlayers";
            btn_RankedListPlayers.UseVisualStyleBackColor = true;
            btn_RankedListPlayers.Click += btn_RankedListPlayers_Click;
            // 
            // btn_RankedListImpressions
            // 
            resources.ApplyResources(btn_RankedListImpressions, "btn_RankedListImpressions");
            btn_RankedListImpressions.Name = "btn_RankedListImpressions";
            btn_RankedListImpressions.UseVisualStyleBackColor = true;
            btn_RankedListImpressions.Click += btn_RankedListImpressions_Click;
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
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private PlayersPanel panel_FavoritePlayers;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_RankedListPlayers;
        private Button btn_RankedListImpressions;
        private FlowLayoutPanel flowLayoutPanel4;
        private GroupBox groupBox3;
        private PlayersPanel panel_Players;
    }
}