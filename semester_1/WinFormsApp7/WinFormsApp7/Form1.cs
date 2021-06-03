using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Math.Round(Double.Parse(textBox1.Text),2);
            double k = Math.Round(f * 0.41,2);
            label2.Text = f + " ф. = " + k + " кг.";
            label2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label2.Text = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9,]"))
            {
                MessageBox.Show("Вводите только цифры.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        
        
        private void enable_button(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0)
                button1.Enabled = true;
            else
            {
                button1.Enabled = false;
            }
        }
    }
}