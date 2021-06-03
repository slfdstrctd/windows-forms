using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace graph
{
    public partial class Form1 : Form
    {
        private readonly double[] d;

        public Form1()
        {
            InitializeComponent();
            StreamReader sr;
            try
            {
                sr = new StreamReader(Application.StartupPath +
                                      "\\usd.dat");
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
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\n" + "(" + ex.GetType() + ")", "График", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void drawDiagram(object sender, PaintEventArgs e)
        {
            var
                g = e.Graphics;
            var
                dFont = new Font("Tahoma",
                    9);
            var hFont = new Font("Tahoma", 14, FontStyle.Regular);
            var
                header = "Курс доллара";
            var w = (int) g.MeasureString(header, hFont).Width;
            var x = (ClientSize.Width - w) / 2;
            g.DrawString(header, hFont, Brushes.Black, x, 5);

            var sw = (ClientSize.Width - 40) / (d.Length - 1);
            var max = d[0];
            var min = d[0];
            for (var i = 1; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }

            int x1, y1, x2, y2;
            x1 = 20;
            y1 = ClientSize.Height - 20 -
                 (int) ((ClientSize.Height - 100) * (d[0] - min) /
                        (max - min)
                 );
            g.DrawRectangle(Pens.Black, x1 - 2, y1 - 2, 4,
                4);
            g.DrawString(Convert.ToString(d[0]), dFont, Brushes.Black, x1 - 10, y1 - 20);

            for (var i = 1; i < d.Length; i++)
            {
                x2 = 8 + i * sw;
                y2 = ClientSize.Height - 20 -
                     (int) ((ClientSize.Height - 100) * (d[i] - min) /
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