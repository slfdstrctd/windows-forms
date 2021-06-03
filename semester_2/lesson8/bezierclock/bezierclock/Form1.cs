using System;
using System.Drawing;
using System.Windows.Forms;

namespace bezierclock
{
    public partial class Form1 : Form
    {
        BezierClockControl clkctl;
        public Form1()
        {
            InitializeComponent();
            Text = "Bezier Clock";

            clkctl = new BezierClockControl();
            clkctl.Parent = this;
            clkctl.Time = DateTime.Now;
            clkctl.Dock = DockStyle.Fill;
            clkctl.BackColor = Color.Coral;
            clkctl.ForeColor = Color.Bisque;

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        void OnTimerTick(object obj, EventArgs ea)
        {
            clkctl.Time = DateTime.Now;
        }
    }
}