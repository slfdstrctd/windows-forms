using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private double Time;
        private int i;
        private string c;
        private bool time_set = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            timer1.Enabled = !(timer1.Enabled);

            if (timer1.Enabled)
            {
                if (!time_set)
                {
                    Time = Decimal.ToDouble(100 * numericUpDown1.Value + numericUpDown2.Value);
                    c = Time.ToString("00:00");
                    i = Int16.Parse(numericUpDown1.Text) * 60 + Int16.Parse(numericUpDown2.Text);

                    Console.Write(i);
                    label1.Text = c;
                    timer1.Interval = 1000;
                    time_set = true;
                }
                
                button1.Text = "Стоп";
                timer1.Start();
            }

            else {
                button1.Text = "Пуск";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tk = --i;
            TimeSpan span = TimeSpan.FromMinutes(tk);
            string label = span.ToString(@"hh\:mm");
            label1.Text = label;
            if (i < 0)
                {
                    timer1.Stop();
                    label1.Text = "00:00";
                    MessageBox.Show("Заданный интервал времени истек", "Таймер", MessageBoxButtons.OK);
                    button1.Enabled = false;
                }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Text.Length != 0) 
                button1.Enabled = true; 
            else button1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Text.Length != 0) 
                button1.Enabled = true; 
            else button1.Enabled = false;
        }
    }
}
