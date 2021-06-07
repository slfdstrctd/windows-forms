using System;
using System.Drawing;
using System.Windows.Forms;

namespace simplegame
{
    public partial class Form1 : Form
    {
        private static int Xt = -24;
        private static int HightFly;
        private static int Rt;
        private static int X0;
        private static int Y0;

        private static int X;

        //protected static int Y;
        private static int Xm;
        private static int Ym;
        private static int Xcur;
        private static int Ycur;
        private static int Ypush;
        private static int Xpush;
        private static int NumberRocket1 = 10;
        private static int NumberRocket2 = 10;
        private static int NumberPlane1;
        private static int NumberPlane2;
        private static bool flug1 = true;
        private static bool flug2;
        private static bool flug3;
        private SolidBrush blackBrush;
        private Pen Blackpen;
        private Pen mainpen;
        private Graphics _graphics;

        private Random rand;
        private Pen Redpen;
        private Image gun;
        private Image plane;

        public Form1()
        {
            InitializeComponent();
            gun = new Bitmap("cannon.png");
            plane = new Bitmap("plane.bmp");
        }

        private void GetPlane(Graphics gr, int x, int y)
        {
            gr.DrawImage(plane, x, y);
            // gr.DrawArc(mainpen, x, y - 2, 30, 5, -265, 340);
            // gr.DrawArc(mainpen, x + 1, y - 7, 4, 10, -220, 190);
            // gr.DrawArc(mainpen, x + 13, y - 10, 5, 20, -20, 190);
            // gr.DrawLine(Blackpen, x + 27, y - 5, x + 28, y + 7);
        }

        private void MyPause(bool ifPause)
        {
            var flag1 = false;
            var flag2 = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                flag1 = true;
            }

            if (timer2.Enabled)
            {
                timer2.Stop();
                flag2 = true;
            }

            if (NumberRocket1 < -1 && NumberRocket2 != 0)
                MessageBox.Show("Извините, генерал, запасы энергии для лазера исчерпаны.");

            if (NumberRocket2 == 0)
            {
                MessageBox.Show("Генерал, управляемые ракеты закончились.");
                NumberRocket2 += -1;
            }

            if (NumberRocket1 == 0 && flug1)
            {
                MessageBox.Show("Генерал, мы исчерпали запасы энергии. Лазер отключен. ");
                NumberRocket1 += -1;
            }

            if (ifPause) MessageBox.Show("      ПАУЗА", "", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (NumberRocket1 == 0)
            {
                MessageBox.Show("Генерал, мы исчерпали запасы энергии. Лазер отключен. ");
                NumberRocket1 += -1;
            }

            if (flag1)
                timer1.Start();
            if (!flag2)
                return;
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPause(true);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                if (!flug2 && NumberRocket2 >= 1 && (Xpush - e.X) * (Xpush - e.X) +
                    (Ypush - e.Y) * (Ypush - e.Y) > 100)
                {
                    Xm = e.X - 5;
                    Ym = e.Y - 5;
                    flug3 = true;
                }

                if (NumberRocket2 == 0)
                    MyPause(false);
            }

            Xcur = e.X - 5;
            Ycur = e.Y - 5;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                var graphics1 = pictureBox1.CreateGraphics();
                var num = (int) Math.Sqrt((Y0 - e.Y) * (Y0 - e.Y) +
                                          (e.X - X0) * (e.X - X0));
                mainpen.Width = 5f;
                if (NumberRocket1 >= 1)
                {
                    var graphics2 = graphics1;
                    var redpen = Redpen;
                    var x1 = X0 + (e.X - X0) * 15 / num;
                    var y0 = Y0;
                    var y1 = y0 - (y0 - e.Y) * 15 / num;
                    var x2 = e.X - 7;
                    var y2 = e.Y - 8;
                    graphics2.DrawLine(redpen, x1, y1, x2, y2);
                    NumberRocket1 += -1;
                    // label3.Text = NumberRocket1.ToString();
                    // pictureBox1.Cle;
                    if (Math.Abs(e.X - Xt - 20) <= 50 && Math.Abs(e.Y - HightFly - 7) <= 50)
                    {
                        X = Xt;
                        flug1 = false;
                    }
                }
                else
                {
                    NumberRocket1 += -1;
                    MyPause(false);
                }

                if (NumberRocket1 >= 0)
                    MyPause(false);
            }

            if (MouseButtons != MouseButtons.Right || flug2)
                return;
            timer2.Start();
            timer2.Enabled = true;
            Xpush = e.X - 5;
            Ypush = e.Y - 5;
            Xm = e.X - 5;
            Ym = e.Y - 5;
            Rt = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var num1 = -100;
            var num2 = -100;
            var graphics1 = e.Graphics;
            var white = Color.White;
            graphics1.Clear(white);

            TextRenderer.DrawText(graphics1, "Лазер", this.Font, new Point(12, 396), Color.Black);
            TextRenderer.DrawText(graphics1, "Ракет", this.Font, new Point(12, 426), Color.Black);


            TextRenderer.DrawText(graphics1, "Уничтожено", this.Font, new Point(575, 396), Color.Black);

            TextRenderer.DrawText(graphics1, "Пропущено", this.Font, new Point(575, 426), Color.Black);
            // 575; 336

            // label8.Text = NumberPlane1.ToString();
            // label8.Text = NumberPlane1.ToString();

            TextRenderer.DrawText(graphics1, NumberRocket1 > 0 ? NumberRocket1.ToString() : "0", this.Font,
                new Point(70, 396), Color.Black);
            TextRenderer.DrawText(graphics1, NumberRocket2 > 0 ? NumberRocket2.ToString() : "0", this.Font,
                new Point(70, 426), Color.Black);

            TextRenderer.DrawText(graphics1, NumberPlane1.ToString(), this.Font, new Point(695, 396), Color.Black);

            TextRenderer.DrawText(graphics1, NumberPlane2.ToString(), this.Font, new Point(695, 426), Color.Black);


            if (flug1)
            {
                GetPlane(graphics1, Xt, HightFly);
            }
            else
            {
                graphics1.DrawEllipse(this.mainpen, Xt + 5, HightFly + (Xt - X) * 3 + 5, 4, 4);
                graphics1.DrawEllipse(this.mainpen, Xt + 5, HightFly - 10 - (Xt - X) * 3 + 5, 4,
                    4);
                graphics1.DrawEllipse(this.mainpen, X * 2 - Xt + 5,
                    HightFly - 10 + (Xt - X) * 3 + 5, 4, 4);
                graphics1.DrawEllipse(this.mainpen, X * 2 - Xt + 5,
                    HightFly - 10 - (Xt - X) * 3 + 5, 4, 4);
                graphics1.DrawEllipse(this.mainpen,
                    (int) (X + (Xt - X) * 1.5 + 5.0),
                    HightFly - 10 + (Xt - X) / 3 + 5, 3, 2);
                graphics1.DrawEllipse(this.mainpen,
                    (int) (X + (Xt - X) * 1.5 + 5.0),
                    HightFly - 10 - (Xt - X) / 3 + 5, 4, 3);
                graphics1.DrawEllipse(this.mainpen,
                    (int) (X - (Xt - X) * 1.5 + 5.0),
                    HightFly - 10 + (Xt - X) / 3 + 5, 3, 5);
                graphics1.DrawEllipse(this.mainpen,
                    (int) (X - (Xt - X) * 1.5 + 5.0),
                    HightFly - 10 - (Xt - X) / 3 + 5, 1, 3);
                graphics1.DrawEllipse(this.mainpen, X + (Xt - X) * 4 + 5,
                    HightFly - 10 + (Xt - X) * 5 / 3 + 5, 2, 4);
                graphics1.DrawEllipse(this.mainpen, X + (Xt - X) * 4 + 5,
                    HightFly - 10 - (Xt - X) * 5 / 3 + 5, 1, 5);
                graphics1.DrawEllipse(this.mainpen, X - (Xt - X) * 4 + 5,
                    HightFly - 10 + (Xt - X) * 5 / 3 + 5, 3, 2);
                graphics1.DrawEllipse(this.mainpen, X - (Xt - X) * 4 + 5,
                    HightFly - 10 - (Xt - X) * 5 / 3 + 5, 4, 3);
            }

            if (timer2.Enabled)
            {
                var num3 = (int) Math.Sqrt((Y0 - Ym) * (Y0 - Ym) +
                                           (Xm - X0) * (Xm - X0));
                graphics1.DrawEllipse(this.mainpen, X0 + Rt * (Xm - X0) / num3,
                    Y0 - Rt * (Y0 - Ym) / num3, 3, 3);
                num1 = X0 + Rt * (Xm - X0) / num3 - 9;
                num2 = Y0 - Rt * (Y0 - Ym) / num3 - 9;
            }

            if (Math.Abs(num1 - Xt - 10) <= 50 && Math.Abs(num2 - HightFly + 6) <= 50)
            {
                X = Xt;
                flug1 = false;
            }

            //graphics1.FillEllipse(blackBrush, X0 - 10, Y0 - 10, 20, 20);

            // graphics1.RotateTransform(-10.0F);
            //graphics1.DrawImage(gun, X0 - 15, Y0 - 15, 25, 25);
            //graphics1.ResetTransform();

            var num4 = (int) Math.Sqrt((Y0 - Ycur) * (Y0 - Ycur) +
                                       (Xcur - X0) * (Xcur - X0));
            this.mainpen.Width = 5f;
            var graphics2 = graphics1;
            var mainpen = this.mainpen;
            var x0 = X0;
            var y0_1 = Y0;
            var x2 = X0 + (Xcur - X0) * 15 / num4;
            var y0_2 = Y0;
            var y2 = y0_2 - (y0_2 - Ycur) * 15 / num4;

            var xdiff = x2 - x0;
            var ydiff = y2 - y0_1;

            float moveX = 25 / 2f + X0 - 15;
            float moveY = 25 / 2f + Y0 - 15;

            _graphics = graphics1;

            graphics1.TranslateTransform(moveX, moveY);

            graphics1.RotateTransform(25.0F);
            var angle = (float) (Math.Atan2(ydiff, xdiff) * 180.0 / Math.PI);
            // if (Math.Abs(angle) < 180)
            graphics1.RotateTransform(angle);
            graphics1.TranslateTransform(-moveX, -moveY);

            graphics1.DrawImage(gun, X0 - 15, Y0 - 15, 25, 25);
            // graphics2.DrawLine(mainpen, x0, y0_1, x2, y2);
            // label4.BringToFront();
            // pictureBox1.Refresh();

            this.mainpen.Width = 3f;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (timer2.Enabled)
                flug2 = true;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = new Cursor("Mytarget.cur");
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Visible = false;
            // label2.Visible = false;
            // label3.Visible = false;
            // label4.Visible = false;
            // label5.Visible = false;
            // label6.Visible = false;
            // label7.Visible = false;
            // label8.Visible = false;
            // label9.Visible = false;
            label1.Text = "5";
            label1.Visible = true;
            NumberRocket1 = 10;
            NumberRocket2 = 10;
            NumberPlane1 = 0;
            NumberPlane2 = 0;
            flug1 = true;
            flug2 = false;
            flug3 = false;
            timer3.Interval = 1000;
            timer3.Start();
            timer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flug1)
            {
                if (Xt <= pictureBox1.Width - 5)
                {
                    Xt += 5;
                }
                else
                {
                    Xt = -24;
                    ++NumberPlane2;
                    // label9.Text = NumberPlane2.ToString();
                    HightFly = (int) Math.Round(rand.NextDouble() * (Y0 * 4.0 / 5.0) + 20.0);
                }

                pictureBox1.Invalidate();
            }
            else
            {
                if (Xt <= X + 15)
                {
                    Xt += 4;
                    pictureBox1.Invalidate();
                }
                else
                {
                    pictureBox1.Invalidate();
                    Xt = -24;
                    ++NumberPlane1;
                    // label8.Text = NumberPlane1.ToString();
                    HightFly = (int) Math.Round(rand.NextDouble() * (Y0 * 4.0 / 5.0) + 20.0);
                    flug1 = true;
                }

                if (NumberRocket2 != 0 && NumberRocket1 != 0)
                    return;
                MyPause(false);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Rt <= (int) Math.Sqrt((Y0 - Ym) * (Y0 - Ym) +
                                      (Xm - X0) * (Xm - X0)) + 4)
            {
                Rt += 5;
                if (!flug1)
                {
                    timer2.Enabled = false;
                    flug2 = false;
                    if (flug3)
                    {
                        NumberRocket2 += -1;
                        flug3 = false;
                        // label5.Text = NumberRocket2.ToString();
                    }
                }
            }
            else
            {
                Rt = 0;
                timer2.Enabled = false;
                flug2 = false;
                if (flug3)
                {
                    NumberRocket2 += -1;
                    flug3 = false;
                    // label5.Text = NumberRocket2.ToString();
                }
            }

            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainpen = new Pen(Color.Black, 3f);
            Blackpen = new Pen(Color.Black, 2f);
            Redpen = new Pen(Color.Red, 1f);
            blackBrush = new SolidBrush(Color.Black);
            rand = new Random();
            X0 = pictureBox1.Width / 2;
            Y0 = pictureBox1.Height;
            HightFly = pictureBox1.Height / 2;
            // label2.Visible = false;
            //label3.Visible = false;
            // label4.Visible = false;
            // label5.Visible = false;
            // label6.Visible = false;
            // label7.Visible = false;
            // label8.Visible = false;
            // label9.Visible = false;
            pictureBox1.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label1.Text != "Старт")
            {
                var num = int.Parse(label1.Text) - 1;
                if (label1.Text != "0")
                    label1.Text = num.ToString();
                if (label1.Text != "0")
                    return;
                label1.Text = "Старт";
            }
            else
            {
                timer3.Stop();
                pictureBox1.Visible = true;
                Xt = -24;
                pictureBox1.Invalidate();
                label1.Visible = false;
                // label2.Visible = true;
                // label3.Visible = true;
                // label4.Visible = true;
                // label5.Visible = true;
                // label6.Visible = true;
                // label7.Visible = true;
                // label8.Visible = true;
                // label9.Visible = true;
                timer1.Interval = 20;
                timer2.Interval = 1;
                // label3.Text = NumberRocket1.ToString();
                // label5.Text = NumberRocket2.ToString();
                // label8.Text = NumberPlane1.ToString();
                // label9.Text = NumberPlane2.ToString();
                timer1.Start();
                timer1.Enabled = true;
            }
        }
    }
}