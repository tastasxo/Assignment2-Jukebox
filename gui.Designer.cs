namespace Tasleem_Bhatti_B7027314_My_Juke_Box
{
    partial class jukebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jukebox));
            this.copyright = new System.Windows.Forms.Label();
            this.genre_listbox = new System.Windows.Forms.ListBox();
            this.genre_title_txtb = new System.Windows.Forms.TextBox();
            this.selectgenrehscroll = new System.Windows.Forms.HScrollBar();
            this.presentplay_txtb = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MediaLibrary = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.SystemColors.WindowText;
            this.copyright.ForeColor = System.Drawing.SystemColors.Window;
            this.copyright.Location = new System.Drawing.Point(260, 9);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(166, 13);
            this.copyright.TabIndex = 0;
            this.copyright.Text = "Copyright © 2018. Tasleem Bhatti";
            // 
            // genre_listbox
            // 
            this.genre_listbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.genre_listbox.FormattingEnabled = true;
            this.genre_listbox.Location = new System.Drawing.Point(160, 188);
            this.genre_listbox.Name = "genre_listbox";
            this.genre_listbox.Size = new System.Drawing.Size(125, 69);
            this.genre_listbox.TabIndex = 1;
            // 
            // genre_title_txtb
            // 
            this.genre_title_txtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.genre_title_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_title_txtb.Location = new System.Drawing.Point(160, 168);
            this.genre_title_txtb.Name = "genre_title_txtb";
            this.genre_title_txtb.Size = new System.Drawing.Size(125, 20);
            this.genre_title_txtb.TabIndex = 2;
            // 
            // selectgenrehscroll
            // 
            this.selectgenrehscroll.Location = new System.Drawing.Point(160, 256);
            this.selectgenrehscroll.Name = "selectgenrehscroll";
            this.selectgenrehscroll.Size = new System.Drawing.Size(125, 19);
            this.selectgenrehscroll.TabIndex = 3;
            // 
            // presentplay_txtb
            // 
            this.presentplay_txtb.BackColor = System.Drawing.Color.Lime;
            this.presentplay_txtb.Location = new System.Drawing.Point(160, 275);
            this.presentplay_txtb.Name = "presentplay_txtb";
            this.presentplay_txtb.Size = new System.Drawing.Size(125, 20);
            this.presentplay_txtb.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(53, 20);
            this.menu.Text = "Set Up";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 556);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(113, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MediaLibrary
            // 
            this.MediaLibrary.Enabled = true;
            this.MediaLibrary.Location = new System.Drawing.Point(160, 116);
            this.MediaLibrary.Name = "MediaLibrary";
            this.MediaLibrary.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaLibrary.OcxState")));
            this.MediaLibrary.Size = new System.Drawing.Size(125, 46);
            this.MediaLibrary.TabIndex = 7;
            // 
            // jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 586);
            this.Controls.Add(this.MediaLibrary);
            this.Controls.Add(this.presentplay_txtb);
            this.Controls.Add(this.selectgenrehscroll);
            this.Controls.Add(this.genre_title_txtb);
            this.Controls.Add(this.genre_listbox);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "jukebox";
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.jukebox_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.ListBox genre_listbox;
        private System.Windows.Forms.TextBox genre_title_txtb;
        private System.Windows.Forms.HScrollBar selectgenrehscroll;
        private System.Windows.Forms.TextBox presentplay_txtb;
        private System.Windows.Forms.ListBox playlist_listbox;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer MediaLibrary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

