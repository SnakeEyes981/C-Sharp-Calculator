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

        private void button1_Click(object sender, EventArgs e)
        {
            if( double.TryParse( textBox1.Text, out double input1 ) && double.TryParse( textBox2.Text, out double input2 ))
            {
                double res = input1 + input2;
                label2.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input1) && double.TryParse(textBox2.Text, out double input2))
            {
                double res = input1 - input2;
                label2.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input1) && double.TryParse(textBox2.Text, out double input2))
            {
                double res = input1 * input2;
                label2.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input1) && double.TryParse(textBox2.Text, out double input2))
            {
                if (input2 == 0)
                {
                    MessageBox.Show("Zero is an Invalid Denominator!");
                }
                else
                {
                    double res = input1 - input2;
                    label2.Text = res.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if( double.TryParse( textBox1.Text, out double input1 ) && double.TryParse( textBox2.Text, out double input2 ))
            {
                double res = input1 % input2;
                label2.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input1) && double.TryParse(textBox2.Text, out double input2))
            {
                double res = Math.Pow(input1, input2);
                label2.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "RESULT";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
