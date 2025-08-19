namespace App_WinForms
{
    partial class PlayersRankedListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersRankedListForm));
            dataGridView1 = new DataGridView();
            PlayerImage = new DataGridViewImageColumn();
            playerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            appearancesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            goalsScoredDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yellowCardsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            playerStatsBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            printToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerStatsBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PlayerImage, playerDataGridViewTextBoxColumn, appearancesDataGridViewTextBoxColumn, goalsScoredDataGridViewTextBoxColumn, yellowCardsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = playerStatsBindingSource;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            // 
            // PlayerImage
            // 
            resources.ApplyResources(PlayerImage, "PlayerImage");
            PlayerImage.Name = "PlayerImage";
            PlayerImage.ReadOnly = true;
            // 
            // playerDataGridViewTextBoxColumn
            // 
            playerDataGridViewTextBoxColumn.DataPropertyName = "Player";
            resources.ApplyResources(playerDataGridViewTextBoxColumn, "playerDataGridViewTextBoxColumn");
            playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            playerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appearancesDataGridViewTextBoxColumn
            // 
            appearancesDataGridViewTextBoxColumn.DataPropertyName = "Appearances";
            resources.ApplyResources(appearancesDataGridViewTextBoxColumn, "appearancesDataGridViewTextBoxColumn");
            appearancesDataGridViewTextBoxColumn.Name = "appearancesDataGridViewTextBoxColumn";
            appearancesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalsScoredDataGridViewTextBoxColumn
            // 
            goalsScoredDataGridViewTextBoxColumn.DataPropertyName = "GoalsScored";
            resources.ApplyResources(goalsScoredDataGridViewTextBoxColumn, "goalsScoredDataGridViewTextBoxColumn");
            goalsScoredDataGridViewTextBoxColumn.Name = "goalsScoredDataGridViewTextBoxColumn";
            goalsScoredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yellowCardsDataGridViewTextBoxColumn
            // 
            yellowCardsDataGridViewTextBoxColumn.DataPropertyName = "YellowCards";
            resources.ApplyResources(yellowCardsDataGridViewTextBoxColumn, "yellowCardsDataGridViewTextBoxColumn");
            yellowCardsDataGridViewTextBoxColumn.Name = "yellowCardsDataGridViewTextBoxColumn";
            yellowCardsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerStatsBindingSource
            // 
            playerStatsBindingSource.DataSource = typeof(DAL.PlayerStats);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { printToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            resources.ApplyResources(printToolStripMenuItem, "printToolStripMenuItem");
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // PlayersRankedListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PlayersRankedListForm";
            SizeGripStyle = SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerStatsBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem printToolStripMenuItem;
        private BindingSource playerStatsBindingSource;
        private DataGridViewImageColumn PlayerImage;
        private DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn appearancesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goalsScoredDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yellowCardsDataGridViewTextBoxColumn;
    }
}