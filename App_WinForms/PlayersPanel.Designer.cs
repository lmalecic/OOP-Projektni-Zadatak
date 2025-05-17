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
            this.panel_Items = new FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel_Items
            // 
            this.panel_Items.AutoScroll = true;
            this.panel_Items.BackColor = Color.Transparent;
            this.panel_Items.Dock = DockStyle.Fill;
            this.panel_Items.Location = new Point(0, 0);
            this.panel_Items.Margin = new Padding(0);
            this.panel_Items.Name = "panel_Items";
            this.panel_Items.Size = new Size(148, 148);
            this.panel_Items.TabIndex = 0;
            // 
            // PlayersPanel
            // 
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.BackColor = SystemColors.Window;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_Items);
            this.Name = "PlayersPanel";
            this.Size = new Size(148, 148);
            this.ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_Items;
    }
}
