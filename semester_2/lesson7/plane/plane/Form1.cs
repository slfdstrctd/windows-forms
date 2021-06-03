using System;
using System.Drawing;
using System.Windows.Forms;

namespace plane
{
    public partial class Form1 : Form
    {
        private readonly bool demo = true;
        private int dx;
        private readonly Graphics g;

        private Rectangle rct;


        private readonly Random rnd;
        private readonly Bitmap sky;
        private readonly Bitmap plane;

        public Form1()
        {
            InitializeComponent();

            try
            {
                sky = new Bitmap("sky.bmp");
                plane = new Bitmap("plane.bmp");

                BackgroundImage = new Bitmap("sky.bmp");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),
                    "Полет",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            plane.MakeTransparent();

            ClientSize =
                new Size(
                    new Point(BackgroundImage.Width, BackgroundImage.Height));


            FormBorderStyle =
                FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            g = Graphics.FromImage(BackgroundImage);

            rnd = new Random();

            rct.X = -40;
            rct.Y = 20 + rnd.Next(20);

            rct.Width = plane.Width;
            rct.Height = plane.Height;


            dx = 2;

            timer1.Interval = 20;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(sky, new Point(0, 0));


            if (rct.X < ClientRectangle.Width)
            {
                rct.X += dx;
            }
            else
            {
                rct.X = -40;
                rct.Y = 20 +
                        rnd.Next(ClientSize.Height - 40 - plane.Height);


                dx = 2 + rnd.Next(4);
            }


            g.DrawImage(plane, rct.X, rct.Y);


            if (!demo)
            {
                Invalidate(rct);
            }
            else
            {
                var reg =
                    new Rectangle(20, 20,
                        sky.Width - 40, sky.Height - 40);


                g.DrawRectangle(Pens.Black,
                    reg.X, reg.Y, reg.Width - 1, reg.Height - 1);

                Invalidate(reg);
            }
        }
    }
}