using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightLog
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void weightTxt_Click(object sender, EventArgs e)
        {

        }

        //Buttons
        private void frontPicBtn_Click(object sender, EventArgs e)
        {
            //Open dialog box to find directory of progress pic
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Console.WriteLine(file);
                frontPicDir.Text = file; //Insert pic directory into textbox
            }
            //Console.WriteLine(result); // <-- For debugging use.
        }

        private void sidePicBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Console.WriteLine(file);
                sidePicDir.Text = file;
            }
            //Console.WriteLine(result); // <-- For debugging use.
        }

        private void backPicBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Console.WriteLine(file);
                backPicDir.Text = file;
            }
            //Console.WriteLine(result); // <-- For debugging use.
        }

        private void facePicBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Console.WriteLine(file);
                facePicDir.Text = file;
            }
            //Console.WriteLine(result); // <-- For debugging use.
        }
        //End buttons

        public void dbQuery(string query)
        {
            //Create MySQL connection
            MySqlConnection connection = new MySqlConnection("server = localhost;user id = root;persistsecurityinfo = True;database = workoutlog;password=password");
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tracker";

            try {
                //Open connection
                connection.Open();
                Console.WriteLine("Connection successful");

                //Read resultset
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    Console.WriteLine(reader.ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (System.Data.SqlTypes.SqlNullValueException nullEx) {
                Console.WriteLine("null");
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex);
                this.Close();
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            //Create folder of current date to hold progress pics for database
            string folderName = @"C:\Users\Zac\Documents\Weight Log"; //Default directory
            string date = DateTime.Today.ToShortDateString(); //Get short date (mm/dd/yy)
            date = date.Replace("/", "."); //Change to (mm.dd.yy) for folder naming purposes
            Console.WriteLine(date);
            string dateFolder = System.IO.Path.Combine(folderName, date); //Set subdirectory
            System.IO.Directory.CreateDirectory(dateFolder); //Create new folder if it doesn't already exist

            //Get pic directories to move pics to newly created directory
            //MoveTo() does not support overwriting so above directory must be empty before operation
            //Front pic
            try {
                FileInfo front = new FileInfo(frontPicDir.Text); //Set chosen pic as a file and move to new dir
                string newFrontPath = Path.Combine(dateFolder, "front.jpg"); //Create new path in date subfolder and rename pic
                front.MoveTo(newFrontPath); //Move pic to above date subfolder
            } catch (Exception ex) {
                Console.WriteLine("Could not find front pic");
            }
            //Side pic
            try {
                FileInfo side = new FileInfo(sidePicDir.Text);
                string newSidePath = Path.Combine(dateFolder, "side.jpg");
                side.MoveTo(newSidePath);
            } catch (Exception ex) {
                Console.WriteLine("Could not find side pic");
            }
            //Back pic
            try {
                FileInfo back = new FileInfo(backPicDir.Text);
                string newBackPath = Path.Combine(dateFolder, "back.jpg");
                back.MoveTo(newBackPath);
            } catch (Exception ex) {
                Console.WriteLine("Could not find back pic");
            }
            //Face pic
            try {
                FileInfo face = new FileInfo(facePicDir.Text);
                string newFacePath = Path.Combine(dateFolder, "face.jpg");
                face.MoveTo(newFacePath);
            } catch (Exception ex) {
                Console.WriteLine("Could not find face pic");
            }
        }
    }
}
