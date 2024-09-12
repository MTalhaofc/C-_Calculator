using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Task1
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;
        double result = 0;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void One_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void Second_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button3_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Three_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void Four_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void Five_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void Six_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void Seven_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void Eight_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void Nine_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void Clear_btn(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void Add_btn(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            textBox1.Text ="";
        }

        private void Minus_btn(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "-";
            textBox1.Text = "";
        }

        private void Multiply_btn(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "*";
            textBox1.Text = "";
        }

        private void Divide_btn(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "/";
            textBox1.Text = "";
        }

        private void Allclear_btn(object sender, EventArgs e)
        {
            value1 = 0;
            value2 = 0;
                sign = "";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Equal_btn(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(textBox1.Text);
            int result = 0; 
      
            switch (sign)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    if (value2 != 0)
                        result = value1 / value2;
                    else
                        MessageBox.Show("Cannot divide by zero."); // Handle division by zero
                    break;
                default:
                    MessageBox.Show("Invalid operation.");
                    break;
            }

            textBox1.Text = result.ToString();
        }
    }
}
