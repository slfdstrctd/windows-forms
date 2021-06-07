using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Diag
{
    public partial class Form1 : Form
    {
        private double[] d;
        private double[] dat;
        private string header;
        private int N;
        private double[] p;
        private string[] title;

        public Form1()
        {
            InitializeComponent();
            StreamReader sr;
            try
            {
                sr = new StreamReader(Application.StartupPath + "\\usd.dat");
                d = new double[10];
                var i = 0;
                var t = sr.ReadLine();


                while (t != null && i < d.Length)
                {
                    d[i++] = Convert.ToDouble(t);
                    t = sr.ReadLine();
                }

                sr.Close();
                Paint += drawDiagram;
                Paint += drawGraph;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\n" + "(" + ex.GetType() + ")", "График",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            try
            {
                // sr;
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                sr = new StreamReader(Application.StartupPath + "\\date.dat",
                    Encoding.GetEncoding("windows-1251"));
                header = sr.ReadLine();
                N = Convert.ToInt16(sr.ReadLine());
                dat = new double[N];
                p = new double[N];
                title = new string[N];
                var i = 0;
                string st;
                st = sr.ReadLine();
                while (st != null && i < N)
                {
                    title[i] = st;
                    st = sr.ReadLine();
                    dat[i++] = Convert.ToDouble(st);
                    st = sr.ReadLine();

                    Paint += drawPie;
                    double sum = 0;
                    int j;
                    for (j = 0; j < N; j++)
                        sum += dat[j];
                    for (j = 0; j < N; j++) p[j] = dat[j] / sum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Диаграмма", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drawDiagram(object sender, PaintEventArgs e)
        {
            var g = tabPage1.CreateGraphics();

            var dFont = new Font("Tahoma", 9);
            var hFont = new Font("Tahoma", 14, FontStyle.Regular);
            var header = "Изменение курса доллара";
            var wh = (int) g.MeasureString(header, hFont).Width;
            var x = (tabPage1.Width - wh) / 2;
            g.DrawString(header, hFont, Brushes.DarkGreen, x, 5);

            var max = d[0];
            var min = d[0];
            for (var i = 1; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }

            int x1, y1;
            int w, h;

            w = (tabPage1.Width - 40 - 5 * (d.Length - 1)) / d.Length;

            x1 = 20;
            for (var i = 0; i < d.Length; i++)
            {
                y1 = tabPage1.Height - 20 -
                     (int) ((tabPage1.Height - 100) * (d[i] - min) /
                            (max - min));
                g.DrawString(Convert.ToString(d[i]), dFont, Brushes.Black, x1, y1 - 20);
                h = tabPage1.Height - y1 - 20 + 1;
                g.FillRectangle(Brushes.ForestGreen, x1, y1, w, h);
                g.DrawRectangle(Pens.Black, x1, y1, w, h);
                x1 = x1 + w + 5;
            }
        }

        private void drawPie(object sender, PaintEventArgs e)
        {
            var g = tabPage3.CreateGraphics();

            var hFont = new Font("Tahoma", 12);
            var w = (int) g.MeasureString(header, hFont).Width;
            var x = (tabPage3.Width - w) / 2;
            g.DrawString(header, hFont, Brushes.Black, x,
                10);
            var lFont = new Font("Tahoma", 9);
            var d = tabPage3.Height - 70;
            var x0 = 30;
            var y0 = (tabPage3.Height - d) / 2 + 10;
            var lx = 60 + d;
            var ly = y0 + (d - N * 20 + 10) / 2;
            var fBrush = Brushes.White;
            var sta = -90;
            for (var i = 0; i < N; i++)
            {
                var swe = (int) (360 *
                                 p[i]);
                switch (i)
                {
                    case 0:
                        fBrush = Brushes.YellowGreen;
                        break;
                    case 1:
                        fBrush = Brushes.Gold;
                        break;
                    case 2:
                        fBrush = Brushes.Pink;
                        break;
                    case 3:
                        fBrush = Brushes.Violet;
                        break;
                    case 4:
                        fBrush = Brushes.OrangeRed;
                        break;
                    case 5:
                        fBrush = Brushes.RoyalBlue;
                        break;
                    case 6:
                        fBrush = Brushes.SteelBlue;
                        break;
                    case 7:
                        fBrush = Brushes.Chocolate;
                        break;
                    case 8:
                        fBrush = Brushes.LightGray;
                        break;
                }

                if (i == N - 1)

                    swe = 270 - sta;

                g.FillPie(fBrush, x0, y0, d, d, sta,
                    swe);
                g.DrawPie(Pens.Black, x0, y0, d, d, sta,
                    swe);
                g.FillRectangle(fBrush, lx, ly + i * 20, 20, 10);
                g.DrawRectangle(Pens.Black, lx, ly + i * 20, 20,
                    10);
                g.DrawString(title[i] + " - " + p[i].ToString("P"), lFont, Brushes.Black, lx + 24,
                    ly + i * 20 -
                    3);
                sta = sta + swe;
            }
        }

        private void drawGraph(object sender, PaintEventArgs e)
        {
            var g = tabPage2.CreateGraphics();
            // g.Clear(this.BackColor);

            var
                dFont = new Font("Tahoma",
                    9);
            var hFont = new Font("Tahoma", 14, FontStyle.Regular);
            var
                header = "Курс доллара";
            var w = (int) g.MeasureString(header, hFont).Width;
            var x = (tabPage2.Width - w) / 2;
            g.DrawString(header, hFont, Brushes.Black, x, 5);

            var sw = (tabPage2.Width - 40) / (d.Length - 1);
            var max = d[0];
            var min = d[0];
            for (var i = 1; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }

            int x1, y1, x2, y2;
            x1 = 20;
            y1 = tabPage2.Height - 20 -
                 (int) ((tabPage2.Height - 100) * (d[0] - min) /
                        (max - min)
                 );
            g.DrawRectangle(Pens.Black, x1 - 2, y1 - 2, 4,
                4);
            g.DrawString(Convert.ToString(d[0]), dFont, Brushes.Black, x1 - 10, y1 - 20);

            for (var i = 1; i < d.Length; i++)
            {
                x2 = 8 + i * sw;
                y2 = tabPage2.Height - 20 -
                     (int) ((tabPage2.Height - 100) * (d[i] - min) /
                            (max - min)
                     );
                g.DrawRectangle(Pens.Black, x2 - 2, y2 - 2, 4,
                    4);
                g.DrawLine(Pens.Black, x1, y1, x2,
                    y2);
                g.DrawString(Convert.ToString(d[i]), dFont, Brushes.Black, x2 - 10, y2 - 20);
                x1 = x2;
                y1 = y2;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}