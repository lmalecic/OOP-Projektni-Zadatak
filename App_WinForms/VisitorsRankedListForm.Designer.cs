namespace App_WinForms
{
    partial class VisitorsRankedListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorsRankedListForm));
            dataGridView1 = new DataGridView();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            homeTeamNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            awayTeamNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            attendanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitorStatsBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            printToPDFToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitorStatsBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { locationDataGridViewTextBoxColumn, homeTeamNameDataGridViewTextBoxColumn, awayTeamNameDataGridViewTextBoxColumn, attendanceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = visitorStatsBindingSource;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            resources.ApplyResources(locationDataGridViewTextBoxColumn, "locationDataGridViewTextBoxColumn");
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeTeamNameDataGridViewTextBoxColumn
            // 
            homeTeamNameDataGridViewTextBoxColumn.DataPropertyName = "HomeTeamName";
            resources.ApplyResources(homeTeamNameDataGridViewTextBoxColumn, "homeTeamNameDataGridViewTextBoxColumn");
            homeTeamNameDataGridViewTextBoxColumn.Name = "homeTeamNameDataGridViewTextBoxColumn";
            homeTeamNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // awayTeamNameDataGridViewTextBoxColumn
            // 
            awayTeamNameDataGridViewTextBoxColumn.DataPropertyName = "AwayTeamName";
            resources.ApplyResources(awayTeamNameDataGridViewTextBoxColumn, "awayTeamNameDataGridViewTextBoxColumn");
            awayTeamNameDataGridViewTextBoxColumn.Name = "awayTeamNameDataGridViewTextBoxColumn";
            awayTeamNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            resources.ApplyResources(attendanceDataGridViewTextBoxColumn, "attendanceDataGridViewTextBoxColumn");
            attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorStatsBindingSource
            // 
            visitorStatsBindingSource.DataSource = typeof(DAL.VisitorStats);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { printToPDFToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // printToPDFToolStripMenuItem
            // 
            resources.ApplyResources(printToPDFToolStripMenuItem, "printToPDFToolStripMenuItem");
            printToPDFToolStripMenuItem.Name = "printToPDFToolStripMenuItem";
            printToPDFToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // VisitorsRankedListForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "VisitorsRankedListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitorStatsBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn homeTeamNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn awayTeamNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private BindingSource visitorStatsBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem printToPDFToolStripMenuItem;
    }
}