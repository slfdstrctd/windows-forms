using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0 && textBox2.Text.Length !=0)
            {
                label3.Text = (Int16.Parse(textBox1.Text) * Int16.Parse(textBox2.Text)).ToString() + " р";
            }

            // throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0 && textBox2.Text.Length !=0)
                button1.Enabled = true;
            else button1.Enabled = false;
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0 && textBox2.Text.Length !=0)
                button1.Enabled = true;
            else button1.Enabled = false;
        }
    }
}