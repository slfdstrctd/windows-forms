using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Diag
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
        }

        private void drawDiagram(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            var dFont = new Font("Tahoma", 9);
            var hFont = new Font("Tahoma", 14, FontStyle.Regular);
            var header = "Изменение курса доллара";
            var wh = (int) g.MeasureString(header, hFont).Width;
            var x = (ClientSize.Width - wh) / 2;
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

            w = (ClientSize.Width - 40 - 5 * (d.Length - 1)) / d.Length;

            x1 = 20;
            for (var i = 0; i < d.Length; i++)
            {
                y1 = ClientSize.Height - 20 -
                     (int) ((ClientSize.Height - 100) * (d[i] - min) /
                            (max - min));
                g.DrawString(Convert.ToString(d[i]), dFont, Brushes.Black, x1, y1 - 20);
                h = ClientSize.Height - y1 - 20 + 1;
                g.FillRectangle(Brushes.ForestGreen, x1, y1, w, h);
                g.DrawRectangle(Pens.Black, x1, y1, w, h);
                x1 = x1 + w + 5;
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}