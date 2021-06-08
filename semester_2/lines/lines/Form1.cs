using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Mainform.xmin.ToString();
            textBox2.Text = Mainform.xmax.ToString();
            textBox3.Text = Mainform.ymin.ToString();
            textBox4.Text = Mainform.ymax.ToString();
            textBox5.Text = Mainform.tmin.ToString();
            textBox6.Text = Mainform.tmax.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform.xmin = float.Parse(textBox1.Text);
            Mainform.xmax = float.Parse(textBox2.Text);
            Mainform.ymin = float.Parse(textBox3.Text);
            Mainform.ymax = float.Parse(textBox4.Text);
            Mainform.tmin = float.Parse(textBox5.Text);
            Mainform.tmax = float.Parse(textBox6.Text);
            this.Close();
        }
    }
}
