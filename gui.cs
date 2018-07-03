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
// This assignment is onsists of four sections:
// 1)creating the main Graphical User Interface (GUI) of the “My Juke Box”. 
//2) second section is for adding the functionality of selecting ‘Genre’ and ‘Tracks’ from the main GUI. 
// 3) Version Control showing understanding of a generic concept
// 4)  “Advanced Programming" to add and remove Genre and Sound Tracks (i.e. using the setup GUI)
{
    public partial class jukebox : Form
    {
        // include the class to enable read and write to disk functions
        // shouldn't be here Imports System.IO; // 
        // Holds the number of Genre, which becomes the number of columns in the array 
        public int Int_Number_of_Genre;
        // holds the number of genre which becomes the number of rows in the array or shows the value in the array when called
        public int Int_Show_Genre_Number;
        // Use for binding the listboxes
        List<string> _items = new List<string>();
        // Create memory allocation for an array of the ListBox/es 
        ListBox[] Media_Library;
        // Tells the JukeBox it is, or not, Playing 
        bool IsPlaying = false;
        // gets us the location from application where it begins
        string line_of_text;
        
        public int Genre { get; private set; }
        public object Num_gen { get; }

        
        // task two | arrays to contain information to do with genre // 
        public jukebox()
        {
            InitializeComponent();
            // items we want to add in the Genre listbox 
            _items.Add("Justin Bieber - Sorry (Dance Video");
            _items.Add("Ellie Goulding - On My Mind");
            _items.Add("Ariana Grande - Focus");

            // Memory allocation for an array of the listbox/es
            ListBox[] Media_Library;
            // Create an array of ListBox/es that remains global 
            Media_Library = new ListBox[Int_Number_of_Genre];
            // Creates each one if required 
            Media_Library[Genre] = new ListBox();
           
        }

        private void Genre_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // declaring the array
            bool[,] Info_Genre = new bool[6, 6]; // // max rows and column elements

            for (int row = 0; row <= 6; row++) // for the row that = 0, row less than or equal to 3, row increments its operhand by 1
                for (int column = 0; column <= 6; column++)
                {
                    // if statments 
                    if ((column == 0) && (row == 0))
                        Media_Library[ [row, column] = true;
                    else
    if (column > 0)
                        if (Media_Library[row, column - 1] == true)
                            Media_Library[row, column] = false;
                        else
                            Media_Library[row, column] = true;
                    if (row > 0)
                        if (Media_Library[row - 1, column] == true)
                            Media_Library[row, column] = false;
                        else
                            Media_Library[row, column] = true;

                    // the loop: 
                    For Gen = 1; to Num_gen; //  
                    Create ListB[Gen] = New; List<T> // creates the listbox itself
             Media_Library[Gen] = New Listbox();
                    Num_track = Readline;
                    ListB[Gen].Item.Add = ReadLine; // add the title 
                    For Track = 1; to Num_track;  // add first track 
                    ListB(Gen).Item.Add = ReadLine; //  adds it by reading the media config file
                    Next; // loops
                    Next; // loops

                }
        }



        // task three // 

        // Include the Class to enable Read and Write to Disk functions 
        // gets us the location from application where it begins
        string line_of_text;
        // Gets the string of the path to the media files for the application 
        public string StrApplicationMediaPath = Directory.GetCurrentDirectory()+"Media.txt\\";
        // Creates a file on the HDD at the Application_Path location called "/Media.txt"
        StreamReader My_Input_Stream = File.OpenText(StrApplicationMediaPath + "Media.txt");
        // get a line of text from the file 
        line_Of_Text = My_Input_Stream.ReadLine()
            while (line_of_text !=null);
            {
            // get the line of text from the file 
            txt_Pad.AppendText(line_of_text + Environment.newLine);
            line_of_text = My_Input_Stream.ReadLine();
             // this closes the file
             My_Input_Stream Close();


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void genre_title_txtbox_Click(object sender, EventArgs e)
        {

            genre_title_txtb.ReadOnly = true;
        }
        private void presentplay_txtbox(object sender, EventArgs e)
        {
            presentplay_txtbox.ReadOnly = true;

        }
        private void Genre_listbox(object sender, EventArgs e)
        {
            genre_listbox.Enabled = false;

        }

        private void playlist_listbox(object sender, EventArgs e)
        {
            playlist_listbox.Enabled = false;

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)

        {
            setup f1 = new setup();
            f1.ShowDialog();


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)

        {
            About f2 = new About();
            f2.ShowDialog();
        }
        private void jukebox_Load(object sender, EventArgs e)
        {
            if (Load_Media_Lists() == false)
            {
                MessageBox.Show("Unable to load the 'Media Content'.");
                Load_Default();
            }

            if (Initailise() == false)
            {
                MessageBox.Show("Unable to display the 'Media Content'.");
                Close();
            }
}

   
   







