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
            this.label1 = new System.Windows.Forms.Label();
            this.Genre_listbox = new System.Windows.Forms.ListBox();
            this.Genre_title = new System.Windows.Forms.TextBox();
            this.selectgenrehscroll = new System.Windows.Forms.HScrollBar();
            this.presentplay_txtbox = new System.Windows.Forms.TextBox();
            this.playlist_listbox = new System.Windows.Forms.ListBox();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2018. Tasleem Bhatti";
            // 
            // Genre_listbox
            // 
            this.Genre_listbox.FormattingEnabled = true;
            this.Genre_listbox.Location = new System.Drawing.Point(160, 188);
            this.Genre_listbox.Name = "Genre_listbox";
            this.Genre_listbox.Size = new System.Drawing.Size(125, 69);
            this.Genre_listbox.TabIndex = 1;
            // 
            // Genre_title
            // 
            this.Genre_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Genre_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre_title.Location = new System.Drawing.Point(160, 168);
            this.Genre_title.Name = "Genre_title";
            this.Genre_title.Size = new System.Drawing.Size(125, 20);
            this.Genre_title.TabIndex = 2;
            this.Genre_title.Text = "General";
            // 
            // selectgenrehscroll
            // 
            this.selectgenrehscroll.Location = new System.Drawing.Point(160, 256);
            this.selectgenrehscroll.Name = "selectgenrehscroll";
            this.selectgenrehscroll.Size = new System.Drawing.Size(125, 19);
            this.selectgenrehscroll.TabIndex = 3;
            // 
            // presentplay_txtbox
            // 
            this.presentplay_txtbox.Location = new System.Drawing.Point(160, 275);
            this.presentplay_txtbox.Name = "presentplay_txtbox";
            this.presentplay_txtbox.Size = new System.Drawing.Size(125, 20);
            this.presentplay_txtbox.TabIndex = 4;
            // 
            // playlist_listbox
            // 
            this.playlist_listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playlist_listbox.FormattingEnabled = true;
            this.playlist_listbox.Location = new System.Drawing.Point(181, 301);
            this.playlist_listbox.Name = "playlist_listbox";
            this.playlist_listbox.Size = new System.Drawing.Size(82, 82);
            this.playlist_listbox.TabIndex = 5;
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.showToolStripMenuItem.Text = "Set Up";
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
            this.showToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 556);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 586);
            this.Controls.Add(this.playlist_listbox);
            this.Controls.Add(this.presentplay_txtbox);
            this.Controls.Add(this.selectgenrehscroll);
            this.Controls.Add(this.Genre_title);
            this.Controls.Add(this.Genre_listbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "jukebox";
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Genre_listbox;
        private System.Windows.Forms.TextBox Genre_title;
        private System.Windows.Forms.HScrollBar selectgenrehscroll;
        private System.Windows.Forms.TextBox presentplay_txtbox;
        private System.Windows.Forms.ListBox playlist_listbox;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

