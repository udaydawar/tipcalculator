using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "100";
            textBox2.Text = "0";
            textBox3.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // button to decrement value of people
            double i;
            i = Convert.ToDouble(textBox3.Text); 
            i--;
            textBox3.Text = Convert.ToString(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // button to increment the tip
            double i;
            i = Convert.ToDouble(textBox2.Text);
            i++;
            textBox2.Text = Convert.ToString(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button to decrement the tip
            double i;
            i = Convert.ToDouble(textBox2.Text);
            i--;
            textBox2.Text = Convert.ToString(i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button to increment the people
            double i;
            i = Convert.ToDouble(textBox3.Text);
            i++;
            textBox3.Text = Convert.ToString(i);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // try block for checking exception
            try
            { 
                double bill, tip, people;   // declaring three variable to store the input
                bill = Convert.ToDouble(textBox1.Text);   //converting them into double
                tip = Convert.ToDouble(textBox2.Text) / 100;
                people = Convert.ToDouble(textBox3.Text);
                if (tip < 0 || people <= 0)  // checking whether the input in tip or people is equal to or greater than zero
                {
                    throw new CustomException("tip or people should be greater zero");   //raising exception
                }
                double tipPerPerson, totalPerPerson;
                tipPerPerson = (bill * tip) / people;      // calculating tip per person
                totalPerPerson = (bill / people) + tipPerPerson;    // calculating amount per person
                listBox1.Items.Clear();
                label4.Text = string.Empty;
                listBox1.Items.Add("tip per person : $" + tipPerPerson);       //displaying result in textbox
                listBox1.Items.Add("total per person : $" + totalPerPerson);
            }
            catch (Exception ex)
            {
                label4.Text = ex.GetType() + " : " + ex.Message;   // catching exception 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)   // ensuring that user cant input any character or backspace 
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)  // ensuring that user cant input any character or backspace
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)   // ensuring that user cant input any character or backspace
            {
                e.Handled = true;
            }
        }
    }
}
