using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lesson5_2
{
    public partial class Form1 : Form
    {
        private readonly string fname;

        private readonly string fpath;
        private readonly Label[] label;
        private readonly int n;


        private readonly RadioButton[] radioButton;
        private readonly int[] test;
        private readonly XDocument xdoc;
        private readonly IEnumerable<XElement> xel;
        private int cv;
        private int mode;

        private int nr;

        private int otv;
        private int right;

        public Form1(string[] args)
        {
            InitializeComponent();

            radioButton = new RadioButton[4];
            label = new Label[4];
            for (var i = 0; i < 4; i++)
            {
                radioButton[i] = new RadioButton
                {
                    Location = new Point(25, 20 + i * 16),
                    Name = "radioButton" + i,
                    Size = new Size(16, 16),
                    Visible = false
                };
                radioButton[i].Click += radioButton1_Click;
                radioButton[i].Parent = this;

                label[i] = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular,
                        GraphicsUnit.Point, 204),
                    Location = new Point(45, 20 + i * 16),
                    MaximumSize = new Size(400, 0),
                    Name = "label" + i,
                    Size = new Size(45, 16)
                };

                radioButton[i].Visible = false;
                label[i].Parent = this;
            }


            if (args.Length > 0)
            {
                fpath = args[0].Substring(0, args[0].LastIndexOf("\\") + 1);
                fname = args[0].Substring(args[0].LastIndexOf("\\") + 1);
            }
            else
            {
                label1.ForeColor = Color.DarkRed;
                label1.Text = "Не указано имя файла теста!";
                mode = 2;
                return;
            }

            try
            {
                xdoc = XDocument.Load(fpath + fname);
                xel = xdoc.Elements();
                label1.Text = xel.Elements("info").ElementAt(0).Value;
                n = xel.Elements("queries").Elements().Count();

                test = new int[n];

                bool[] b;
                b = new bool[n];
                for (var i = 0; i < n; i++) b[i] = false;

                var rnd = new Random();
                int r;
                for (var i = 0; i < n; i++)
                {
                    do
                    {
                        r = rnd.Next(n);
                    } while (b[r]);

                    test[i] = r;
                    b[r] = true;
                }

                mode = 0;
                cv = 0;
            }
            catch (Exception)
            {
                label1.ForeColor = Color.DarkRed;

                label1.Text = fpath + fname;
                mode = 2;
            }
        }

        private void qw(int i)
        {
            int j;
            for (j = 0; j < 4; j++)
            {
                label[j].Visible = false;
                radioButton[j].Visible = false;
            }


            label1.Text = xel.Elements("queries").Elements().ElementAt(i).Element("q").Value;
            right = Convert.ToInt32(xel.Elements("queries").Elements().ElementAt(i).Element("q")
                .Attribute("right").Value);

            var src = xel.Elements("queries").Elements().ElementAt(i).Element("q").Attribute("src").Value;
            if (src.Length != 0)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(fpath + src);
                    pictureBox1.Visible = true;
                    radioButton[0].Top = pictureBox1.Bottom + 16;
                    label[0].Top = radioButton[0].Top - 3;
                }
                catch
                {
                    if (pictureBox1.Visible) pictureBox1.Visible = false;
                    radioButton[0].Top = label1.Bottom + 10;
                    label[0].Top = radioButton[0].Top - 3;
                }
            }
            else
            {
                pictureBox1.Visible = false;
                radioButton[0].Top = label1.Bottom + 10;
                label[0].Top = radioButton[0].Top - 3;
            }

            j = 0;
            foreach (var a in xel.Elements("queries").Elements().ElementAt(i).Element("as").Elements())
            {
                label[j].Text = a.Value;
                label[j].Visible = true;
                radioButton[j].Visible = true;
                if (j != 0)
                {
                    radioButton[j].Top = label[j - 1].Bottom + 20;
                    label[j].Top = radioButton[j].Top;
                }

                j++;
            }

            button1.Enabled = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if ((RadioButton) sender == radioButton[0]) otv = 1;
            if ((RadioButton) sender == radioButton[1]) otv = 2;
            if ((RadioButton) sender == radioButton[2]) otv = 3;
            if ((RadioButton) sender == radioButton[3]) otv = 4;
            button1.Enabled = true;
        }

        private void ShowResult()
        {
            int
                k;
            int i;
            var p = 0;
            k = xel.Elements("levels").Elements().Count();
            for (i = 0; i < k - 1; i++)
            {
                p = Convert.ToInt32(xel.Elements("levels").Elements().ElementAt(i).Attribute("p").Value);
                if (nr >= p)
                    break;
            }

            label1.Text = "Всего вопросов: " + n + "\n" + "Правильных ответов: " + nr + "\n" +
                          "Оценка: " + xel.Elements("levels").Elements().ElementAt(i).Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    qw(test[cv]);
                    cv++;
                    mode = 1;
                    break;
                case 1:
                    if (otv == right)
                        nr++;
                    if (cv < n)
                    {
                        qw(test[cv]);
                        cv++;
                    }
                    else
                    {
                        for (var j = 0; j < 4; j++)
                        {
                            label[j].Visible = false;
                            radioButton[j].Visible = false;
                        }

                        pictureBox1.Visible = false;
                        ShowResult();
                        mode = 2;
                    }

                    break;
                case 2:
                    Close();
                    break;
            }
        }
    }
}