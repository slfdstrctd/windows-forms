using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        double Time = 0.0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled)
            {
                button1.Text = "Cтоп";
                button2.Enabled = false;
                
            }
            else
            {
                button1.Text = "Пуск";
                button2.Enabled = true;
            }
            
            
            // START STOP
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "00:00";
            Time = 0;
            // RESET
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time += 0.001 * timer1.Interval;
            label1.Text = Time.ToString("00:00");
        }
    }
}