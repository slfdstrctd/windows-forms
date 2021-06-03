using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace lesson2_4
{
    public partial class Form1 : Form
    {
        private int _n;
        private DataTable _dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Решение системы уравнений";
            textBox1.TabIndex = 0;
            dataGridView1.Visible = false;
            label1.Text = "Ведите количество неизвестных:";
            button1.Text = "Ввести";
            _dt = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            double[,] a;
            double[] l;
            var isNum = false;
            string tmp;
            if (button1.Text == "Ввести")
                for (;;)
                {
                    isNum = int.TryParse(textBox1.Text,
                        NumberStyles.Integer,
                        NumberFormatInfo.CurrentInfo,
                        out _n);
                    if (isNum == false) return;
                    button1.Text = "Решить";
                    textBox1.Enabled = false;
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = _dt;
                    for (i = 1; i <= _n; i++)
                    {
                        tmp = "X" + Convert.ToString(i);
                        _dt.Columns.Add(new DataColumn(tmp));
                    }

                    _dt.Columns.Add(new DataColumn("L"));
                    return;
                }

            if (_dt.Rows.Count != _n)
            {
                MessageBox.Show(
                    "Количество строк не равно количеству колонок");
                return;
            }

            a = new double[_n, _n];
            l = new double[_n];
            for (j = 0; j <= _n - 1; j++)
            {
                for (i = 0; i <= _n - 1; i++)
                {
                    a[j, i] = ret_num(j, i, ref isNum);
                    if (isNum == false) return;
                }

                l[j] = ret_num(j, i, ref isNum);
                if (isNum == false) return;
            }

            Gauss(_n, a, ref l);

            var s = "Неизвестные равны:\n";
            for (j = 1; j <= _n; j++)
            {
                tmp = l[j - 1].ToString();
                s = s + "X" + j + " = " + tmp + ";\n";
            }

            MessageBox.Show(s);
        }

        private double ret_num(int j, int i,
            ref bool isNum)
        {
            var tmp = _dt.Rows[j][i].ToString();
            isNum = double.TryParse(tmp,
                NumberStyles.Number,
                NumberFormatInfo.CurrentInfo,
                out var t);
            if (isNum == false)
            {
                tmp = $"Номер строки {j + 1}, номер столбца " + $"{i + 1}," + "\n в данном поле - не число";
                MessageBox.Show(tmp);
            }

            return t;
        }

        private static void Gauss(int m, double[,] a, ref double[] ll)
        {
            int i, j, l = 0;
            for (i = 0; i <= m - 1; i++)
            {
                double c1 = 0;
                for (j = i; j <= m - 1; j++)
                {
                    var c2 = a[j, i];
                    if (Math.Abs(c2) > Math.Abs(c1))
                    {
                        l = j;
                        c1 = c2;
                    }
                }

                double c3;
                for (j = i; j <= m - 1; j++)
                {
                    c3 = a[l, j] / c1;
                    a[l, j] = a[i, j];
                    a[i, j] = c3;
                }

                c3 = ll[l] / c1;
                ll[l] = ll[i];
                ll[i] = c3;

                for (j = 0; j <= m - 1; j++)
                {
                    if (j == i) continue;
                    for (l = i + 1; l <= m - 1; l++)
                    {
                        a[j, l] = a[j, l] - a[i, l] * a[j, i];
                    }

                    ll[j] = ll[j] - ll[i] * a[j, i];
                }
            }
        }
    }
}