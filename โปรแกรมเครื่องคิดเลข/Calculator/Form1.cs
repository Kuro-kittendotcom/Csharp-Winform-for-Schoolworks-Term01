using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = 0, num2 = 0, result = 0;
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            catch (Exception) 
            {
                MessageBox.Show("Pls check your input again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = 0, num2 = 0, result = 0;
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Pls check your input again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = 0, num2 = 0, result = 0;
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 * num2;
                textBox3.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Pls check your input again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = 0, num2 = 0, result = 0;
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 / num2;
                textBox3.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Pls check your input again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.Focus();
            }
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.Focus();
            }
        }
    }
}
