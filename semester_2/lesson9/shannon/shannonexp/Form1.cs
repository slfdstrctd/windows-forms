using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shannonexp
{
    public partial class Form1 : Form
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly int nRows = 4;
        private static readonly int nCols = 10;
        private readonly Control[] atile = new Control[33];
        private string a;
        private readonly string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private int curr;
        private static int n;
        private readonly string text = File.ReadAllText(path + "\\text.txt", Encoding.Default);
        private int[] tries = new int[n];

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = text.Length - 1;
            var grfx = CreateGraphics();
            var sizeTile = new Size((int) (2 * grfx.DpiX / 3),
                (int) (2 * grfx.DpiY / 3));

            for (var iRow = 0; iRow < nRows; iRow++)
            for (var iCol = 0; iCol < nCols; iCol++)
            {
                var iNum = iRow * nCols + iCol + 1;

                if (iNum == nRows * nCols)
                    continue;

                if (iNum > 33) break;

                var tile = new CharButton(iNum - 1, alphabet[iNum - 1].ToString());
                tile.Parent = this;
                tile.Location = new Point(iCol * sizeTile.Width,
                    200 + iRow * sizeTile.Height);
                tile.Size = new Size(new Point(sizeTile));
                // tile.Text = ;
                // tile.Name = iNum.ToString();
                tile.Click += tile_Click;

                atile[iNum - 1] = tile;
            }
        }

        private void tile_Click(object? sender, EventArgs eventArgs)
        {
            var s = sender as CharButton;
            if (s != null && a != null)
            {
                tries[curr]++;
                // MessageBox.Show(tries[0].ToString());

                if (s.Text != a[curr].ToString())
                {
                    label3.Text = "Не угадали!";
                    s.Enabled = false;
                }
                else
                {
                    enableTiles(true);
                    double res = 0;
                    if (curr != n - 1) curr++;
                    else
                    {
                        // SHOW SHANNON
                        int sum = tries.Sum();
                        double p;
                        foreach (var t in tries)
                        {
                            p = t / (double) sum;
                            res += -p * Math.Log2(p);
                        }

                        label4.Text = res.ToString(CultureInfo.InvariantCulture);
                        enableTiles(false);
                    }

                    textBox1.Text += s.Text;
                    label3.Text = "Угадали!";
                }
            }
            else
            {
                MessageBox.Show("Слово не сгенерировано!");
            }
        }

        private void enableTiles(bool f)
        {
            foreach (var t in atile) t.Enabled = f;
        }

        public static bool IsAllLetters(string s)
        {
            foreach (var c in s)
                if (!char.IsLetter(c))
                    return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (int) numericUpDown1.Value;
            tries = new int[n];
            curr = 0;
            label4.Text = "";

            if (n >= 2 && n < 17)
            {
                var rnd = new Random();
                do
                {
                    var index = rnd.Next(0, text.Length - n);
                    a = text.Substring(index, n);
                } while (!IsAllLetters(a));

                textBox1.Text = "";
                label3.Text = "";
                // label3.Text = a.Substring(n - 1, 1);
                // TODO
                label4.Text = a.Substring(0, n);
                enableTiles(true);
            }
            else
            {
                MessageBox.Show("Неверное значение n!");
            }
        }
    }
}