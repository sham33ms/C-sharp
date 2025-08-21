using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rollnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            int Phy = int.Parse(textBox2.Text);
            int Math = int.Parse(textBox3.Text);
            int Chem = int.Parse(textBox4.Text);
            int Cuttoff = (Phy + Math + Chem) / 3;
            //string marks1= markstxt.Text;
            //string marks2 = markstxt2.Text;


            if (Phy < 0 || Phy > 100)
            {
                MessageBox.Show("Please enter a valid number (0-100) for Mark 1", "Input Error");
                return;
            }

            // Validate mark2
            if (Math < 0 || Math > 100)
            {
                MessageBox.Show("Please enter a valid number (0-100) for Mark 2", "Input Error");
                return;
            }

            // Validate mark3
            if (Chem < 0 || Chem > 100)
            {
                MessageBox.Show("Please enter a valid number (0-100) for Mark 3", "Input Error");
                return;
            }


            string result;

            if (Cuttoff > 90)
            {
                result = "Eligible for Engineering";
                labelResult.ForeColor = Color.Green;   // Text in Green
            }
            else if (Cuttoff > 70)
            {
                result = "Eligible for Tech";
                labelResult.ForeColor = Color.Blue;    // Text in Blue
            }
            else if (Cuttoff > 40)
            {
                result = "Not Eligible";
                labelResult.ForeColor = Color.Orange;  // Text in Orange
            }
            else
            {
                result = "Fail";
                labelResult.ForeColor = Color.Red;     // Text in Red
            }

            // Show result in Label on the form
            labelResult.Text = result;

            //Radio Buttons for gender
            string gender = "";
            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";
            else gender = "Not Mentioned";

             dataGridView1.Rows.Add(Name, gender ,Phy, Math, Chem, Cuttoff, result);// DataGridView Whcich is used as a table

            
            



            // Show in MessageBox
            MessageBox.Show("Roll No: " + Name +
                "\n Gender: "+gender +
                "\nPhysics: " + Phy + " out of 100" +
                "\nMath: " + Math + " out of 100" +
                "\nChemistry: " + Chem + " out of 100" +
                "\nThe Cuttoff is " + Cuttoff +
                "\n Eligible or Not: " + result,
                "Student Details");
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            labelResult.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
