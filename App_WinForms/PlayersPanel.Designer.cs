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
            panel_Items = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_Items
            // 
            panel_Items.AllowDrop = true;
            panel_Items.BackColor = SystemColors.Highlight;
            panel_Items.Dock = DockStyle.Fill;
            panel_Items.Location = new Point(20, 20);
            panel_Items.Margin = new Padding(0);
            panel_Items.Name = "panel_Items";
            panel_Items.Size = new Size(129, 157);
            panel_Items.TabIndex = 0;
            // 
            // PlayersPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel_Items);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlayersPanel";
            Padding = new Padding(20);
            Size = new Size(169, 197);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Items;
    }
}
