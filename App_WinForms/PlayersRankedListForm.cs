using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class PlayersRankedListForm : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintDialog printDialog1 = new PrintDialog();
        private int printRowIndex = 0;
        private int[]? printColWidths = null;

        public PlayersRankedListForm()
        {
            InitializeComponent();
            LoadList();
            printDocument1.PrintPage += PrintDocument1_PrintPage;
        }

        private async void LoadList()
        {
            if (App.Config.FavoriteTeam == null)
            {
                MessageBox.Show("Please select a favorite team in settings.", "No Favorite Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var players = await App.WorldCupRepository.GetTeamPlayers(App.Config.Tournament, App.Config.FavoriteTeam);

            var statTasks = players
                .Select(player => App.WorldCupRepository.GetPlayerStats(App.Config.Tournament, player))
                .ToList();

            var statsResults = await Task.WhenAll(statTasks);

            var playerStats = statsResults
                .Where(stats => stats != null)
                .OrderByDescending(stats => stats.GoalsScored)
                .ThenByDescending(stats => stats.YellowCards)
                .ToList();

            dataGridView1.DataSource = playerStats;

            for (int i = 0; i < playerStats.Count; i++)
            {
                var player = playerStats[i].Player;
                var imageBytes = await App.ImageRepository.LoadPlayerImage(player);
                Bitmap bmp;

                if (imageBytes != null)
                {
                    using (var ms = new MemoryStream(imageBytes))
                        bmp = new Bitmap(ms);
                }
                else
                {
                    bmp = Properties.Resources.PlayerSlot;
                }

                if (!this.Visible)
                    return;

                int cellSize = dataGridView1.Rows[i].Height;
                Bitmap resizedBmp = new Bitmap(bmp, new Size(cellSize, cellSize));
                dataGridView1.Rows[i].Cells["PlayerImage"].Value = resizedBmp;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int rowHeight = dataGridView1.RowTemplate.Height;
            int colCount = dataGridView1.Columns.Count;
            int y = topMargin;
            Font font = new Font("Comic Sans MS", 10);

            if (printColWidths == null)
            {
                printColWidths = new int[colCount];
                using (Graphics g = dataGridView1.CreateGraphics())
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        int maxWidth = (int)g.MeasureString(dataGridView1.Columns[col].HeaderText, font).Width + 10;
                        for (int row = 0; row < dataGridView1.Rows.Count; row++)
                        {
                            var cellValue = dataGridView1.Rows[row].Cells[col].Value;
                            if (cellValue is Bitmap bmp)
                            {
                                maxWidth = Math.Max(maxWidth, bmp.Width + 10);
                            }
                            else
                            {
                                int cellWidth = (int)g.MeasureString(cellValue?.ToString() ?? "", font).Width + 10;
                                maxWidth = Math.Max(maxWidth, cellWidth);
                            }
                        }
                        printColWidths[col] = maxWidth;
                    }
                }
            }

            int x = leftMargin;
            for (int col = 0; col < colCount; col++)
            {
                int colWidth = printColWidths[col];
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, colWidth, rowHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, colWidth, rowHeight));
                e.Graphics.DrawString(dataGridView1.Columns[col].HeaderText, font, Brushes.Black, x + 2, y + 2);
                x += colWidth;
            }
            y += rowHeight;

            while (printRowIndex < dataGridView1.Rows.Count)
            {
                x = leftMargin;
                DataGridViewRow row = dataGridView1.Rows[printRowIndex];

                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                for (int col = 0; col < colCount; col++)
                {
                    int colWidth = printColWidths[col];
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, colWidth, rowHeight));

                    var cellValue = row.Cells[col].Value;
                    if (cellValue is Bitmap bmp)
                    {
                        int imgSize = Math.Min(rowHeight - 4, colWidth - 4);
                        e.Graphics.DrawImage(bmp, x + 2, y + 2, imgSize, imgSize);
                    }
                    else
                    {
                        e.Graphics.DrawString(cellValue?.ToString() ?? "", font, Brushes.Black, x + 2, y + 2);
                    }
                    x += colWidth;
                }
                y += rowHeight;
                printRowIndex++;
            }

            printRowIndex = 0;
            printColWidths = null;
            e.HasMorePages = false;
        }
    }
}
