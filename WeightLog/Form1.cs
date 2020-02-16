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
        }
        //End buttons

        public void dbQuery(string query)
        {
            //Create MySQL connection
            MySqlConnection connection = new MySqlConnection("server = localhost;user id = root;persistsecurityinfo = True;database = weight_log;password=password");
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

        public void dbInsert(double weight, string frontpic, string sidepic, string backpic, string facepic, string log, double waist, double stomach, double biceps, double chest, double thigh)
        {
            //Create MySQL connection
            MySqlConnection connection = new MySqlConnection("server = localhost;user id = root;persistsecurityinfo = True;database = weight_log;password=password");
            MySqlCommand cmd = connection.CreateCommand();
            //Insert statement with date insert auto generated using CURDATE (yyyy-mm-dd)
            cmd.CommandText = "INSERT INTO tracker(date, weight, frontpic, sidepic, backpic, facepic, log, waistsize, stomachsize," +
                " bicepsize, chestsize, thighsize) VALUES(CURDATE(), \"" + weight + "\", \"" + frontpic + "\", \"" + sidepic + "\", \"" + 
                backpic + "\", \"" + facepic + "\", \"" + log + "\", \"" + waist + "\", \"" + stomach + "\", \"" + biceps + "\", \"" + chest + "\", \"" + thigh + "\")";
            Console.WriteLine(cmd.CommandText);

            try {
                connection.Open();
                Console.WriteLine("Connection successful");
                MySqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Insert successful");
            } catch(Exception ex) {
                Console.WriteLine(ex);
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

            //Check to see if folder exists, if it does, delete and recreate
            if(System.IO.Directory.Exists(dateFolder))
            {
                System.IO.Directory.Delete(dateFolder);
            }
            System.IO.Directory.CreateDirectory(dateFolder); //Create new folder if it doesn't already exist

            //Variables to work with
            double weight = Double.Parse(weightTxtBox.Text); //Weight
            string log = thoughtTxt.Text; //Log text
            string newFrontPath = "";
            string newSidePath = "";
            string newBackPath = "";
            string newFacePath = "";
            double waist = Double.Parse(waistTxtBox.Text);
            double stomach = Double.Parse(stomachTxtBox.Text);
            double bicep = Double.Parse(bicepTxtBox.Text);
            double chest = Double.Parse(chestTxtBox.Text);
            double thigh = Double.Parse(thighTxtBox.Text);


            //Get pic directories to move pics to newly created directory
            //MoveTo() does not support overwriting so above directory must be empty before operation
            //Front pic
            try {
                FileInfo front = new FileInfo(frontPicDir.Text); //Set chosen pic as a file and move to new dir
                newFrontPath = Path.Combine(dateFolder, "front.jpg"); //Create new path in date subfolder and rename pic
                front.MoveTo(newFrontPath); //Move pic to above date subfolder
            } catch (Exception ex) {
                Console.WriteLine("Could not find front pic " + ex);
            }
            //Side pic
            try {
                FileInfo side = new FileInfo(sidePicDir.Text);
                newSidePath = Path.Combine(dateFolder, "side.jpg");
                side.MoveTo(newSidePath);
            } catch (Exception ex) {
                Console.WriteLine("Could not find side pic " + ex);
            }
            //Back pic
            try {
                FileInfo back = new FileInfo(backPicDir.Text);
                newBackPath = Path.Combine(dateFolder, "back.jpg");
                back.MoveTo(newBackPath);
            } catch (Exception ex) {
                Console.WriteLine("Could not find back pic " + ex);
            }
            //Face pic
            try {
                FileInfo face = new FileInfo(facePicDir.Text);
                newFacePath = Path.Combine(dateFolder, "face.jpg");
                face.MoveTo(newFacePath);
            } catch (Exception ex) {
                Console.WriteLine("Could not find face pic " + ex);
            }

            //INSERT SQL statement
            newFrontPath = newFrontPath.Replace(@"\", @"\\"); //Replace backslash with double backslash so that the backslash escapes in the insert
            newSidePath = newSidePath.Replace(@"\", @"\\");
            newBackPath = newBackPath.Replace(@"\", @"\\");
            newFacePath = newFacePath.Replace(@"\", @"\\");
            dbInsert(weight, newFrontPath, newSidePath, newBackPath, newFacePath, log, waist, stomach, bicep, chest, thigh); //Insert new row into DB
        }


    }
}
