using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace сDiag
{
    public partial class Form1 : Form
    {
        private readonly double[] dat;
        private readonly string header;
        private readonly int N;
        private readonly double[] p;
        private readonly string[] title;

        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader sr;
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


                    Paint += Diagram;
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

        private void Diagram(object sender, PaintEventArgs e)
        {
            var
                g = e.Graphics;
            var
                hFont = new Font("Tahoma",
                    12);
            var w = (int) g.MeasureString(header, hFont).Width;
            var x = (ClientSize.Width - w) / 2;
            g.DrawString(header, hFont, Brushes.Black, x,
                10);
            var lFont = new Font("Tahoma", 9);
            var d = ClientSize.Height - 70;
            var x0 = 30;
            var y0 = (ClientSize.Height - d) / 2 + 10;
            var lx = 60 + d;
            var ly = y0 + (d - N * 20 + 10) / 2;
            var fBrush = Brushes.White;
            var
                sta = -90;
            for (var i = 0; i < N; i++)
            {
                var swe = (int) (360 *
                                 p[i]
                    );
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
    }
}