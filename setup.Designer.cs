namespace Tasleem_Bhatti_B7027314_My_Juke_Box
{
    partial class setup
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
            this.setup_interface = new System.Windows.Forms.GroupBox();
            this.tracklist = new System.Windows.Forms.GroupBox();
            this.nxt_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.prev_button = new System.Windows.Forms.Button();
            this.track_listbox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gnre_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.move_button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.imp_track = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.lbox = new System.Windows.Forms.ListBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.setup_interface.SuspendLayout();
            this.tracklist.SuspendLayout();
            this.imp_track.SuspendLayout();
            this.SuspendLayout();
            // 
            // setup_interface
            // 
            this.setup_interface.Controls.Add(this.tracklist);
            this.setup_interface.Controls.Add(this.delete_button);
            this.setup_interface.Controls.Add(this.move_button);
            this.setup_interface.Controls.Add(this.copy_button);
            this.setup_interface.Controls.Add(this.imp_track);
            this.setup_interface.Location = new System.Drawing.Point(12, 12);
            this.setup_interface.Name = "setup_interface";
            this.setup_interface.Size = new System.Drawing.Size(630, 388);
            this.setup_interface.TabIndex = 0;
            this.setup_interface.TabStop = false;
            // 
            // tracklist
            // 
            this.tracklist.Controls.Add(this.nxt_button);
            this.tracklist.Controls.Add(this.del_button);
            this.tracklist.Controls.Add(this.add_button);
            this.tracklist.Controls.Add(this.prev_button);
            this.tracklist.Controls.Add(this.track_listbox);
            this.tracklist.Controls.Add(this.textBox1);
            this.tracklist.Controls.Add(this.gnre_label);
            this.tracklist.Location = new System.Drawing.Point(394, 14);
            this.tracklist.Name = "tracklist";
            this.tracklist.Size = new System.Drawing.Size(230, 315);
            this.tracklist.TabIndex = 4;
            this.tracklist.TabStop = false;
            this.tracklist.Text = "Present Genre Track List";
            // 
            // nxt_button
            // 
            this.nxt_button.Location = new System.Drawing.Point(166, 235);
            this.nxt_button.Name = "nxt_button";
            this.nxt_button.Size = new System.Drawing.Size(58, 74);
            this.nxt_button.TabIndex = 6;
            this.nxt_button.Text = "Next >>";
            this.nxt_button.UseVisualStyleBackColor = true;
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(85, 264);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 23);
            this.del_button.TabIndex = 5;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(85, 235);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // prev_button
            // 
            this.prev_button.Location = new System.Drawing.Point(6, 235);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(73, 74);
            this.prev_button.TabIndex = 3;
            this.prev_button.Text = "<< Previous";
            this.prev_button.UseVisualStyleBackColor = true;
            // 
            // track_listbox
            // 
            this.track_listbox.FormattingEnabled = true;
            this.track_listbox.Location = new System.Drawing.Point(11, 69);
            this.track_listbox.Name = "track_listbox";
            this.track_listbox.Size = new System.Drawing.Size(213, 160);
            this.track_listbox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Genre";
            // 
            // gnre_label
            // 
            this.gnre_label.AutoSize = true;
            this.gnre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnre_label.Location = new System.Drawing.Point(10, 16);
            this.gnre_label.Name = "gnre_label";
            this.gnre_label.Size = new System.Drawing.Size(87, 20);
            this.gnre_label.TabIndex = 0;
            this.gnre_label.Text = "Genre Title";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(286, 225);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(102, 42);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "Delete Track from Genre";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // move_button
            // 
            this.move_button.Location = new System.Drawing.Point(286, 93);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(102, 43);
            this.move_button.TabIndex = 2;
            this.move_button.Text = "Move Track >>";
            this.move_button.UseVisualStyleBackColor = true;
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(286, 35);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(102, 43);
            this.copy_button.TabIndex = 1;
            this.copy_button.Text = "Copy Track >>";
            this.copy_button.UseVisualStyleBackColor = true;
            // 
            // imp_track
            // 
            this.imp_track.Controls.Add(this.clear_button);
            this.imp_track.Controls.Add(this.import_button);
            this.imp_track.Controls.Add(this.lbox);
            this.imp_track.Location = new System.Drawing.Point(5, 11);
            this.imp_track.Name = "imp_track";
            this.imp_track.Size = new System.Drawing.Size(268, 318);
            this.imp_track.TabIndex = 0;
            this.imp_track.TabStop = false;
            this.imp_track.Text = "Imported Tracks";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(6, 281);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(253, 25);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "Clear Import Tracks";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // import_button
            // 
            this.import_button.Location = new System.Drawing.Point(6, 250);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(253, 25);
            this.import_button.TabIndex = 1;
            this.import_button.Text = "Import Tracks from Directory";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(6, 18);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(253, 225);
            this.lbox.TabIndex = 0;
            this.lbox.SelectedIndexChanged += new System.EventHandler(this.lbox_SelectedIndexChanged);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(444, 425);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 7;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(557, 425);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 475);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.setup_interface);
            this.Name = "setup";
            this.Text = "Set Up";
            this.Load += new System.EventHandler(this.setup_Load);
            this.setup_interface.ResumeLayout(false);
            this.tracklist.ResumeLayout(false);
            this.tracklist.PerformLayout();
            this.imp_track.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox setup_interface;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.GroupBox imp_track;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.GroupBox tracklist;
        private System.Windows.Forms.Label gnre_label;
        private System.Windows.Forms.Button nxt_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.ListBox track_listbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}