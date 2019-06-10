using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void frontPicBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Console.WriteLine(file);
                frontPicDir.Text = file;
            }
            Console.WriteLine(result); // <-- For debugging use.
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
            Console.WriteLine(result); // <-- For debugging use.
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
            Console.WriteLine(result); // <-- For debugging use.
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
            Console.WriteLine(result); // <-- For debugging use.
        }

        public void dbQuery(string text)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost;user id = root;persistsecurityinfo = True;database = workoutlog;password=password");
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM tracker";

            try {
                connection.Open();
                Console.WriteLine("Connection successful");
            }
            catch (Exception erro) {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine(reader.GetString("weight"));
            }
            connection.Close();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            dbQuery("44");
        }
    }
}
