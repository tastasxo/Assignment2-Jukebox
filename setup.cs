using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;





namespace Tasleem_Bhatti_B7027314_My_Juke_Box
{
    public partial class setup : Form
    { 

        public setup()
        {
            InitializeComponent();
        }

        private void lbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            // Tells the application that something has changed 
            bool_Requires_Saving = true;
            // Let the user select the directory the music is comming from 
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Populates the list array with all the files with the stated extension foreach (string file in _ Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath,"*.*",_ SearchOption.AllDirectories).Where(s => s.EndsWith(".mp3") || _ s.EndsWith(".wma") || s.EndsWith(".wav") || s.EndsWith(".MP3") || _ s.EndsWith(".WMA") || s.EndsWith(".WAV")))
                {
                    import_button.Items.Add();
                }
                if (import_button.Items.Count > -1)
                {
                    import_button.Enabled = false;
                }
                else
                {
                    import_button.Enabled = true;
                }
            }
        }

        private void setup_Load(object sender, EventArgs e)
        {

        }
    }
}