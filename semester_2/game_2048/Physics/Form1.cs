using System;
using System.Drawing;
using System.Windows.Forms;

namespace Physics
{
    public partial class Form1 : Form
    {
        private readonly Label[,] labels = new Label[4, 4]; // надписи

        private readonly int[,] map = new int[4, 4];
        private readonly PictureBox[,] pics = new PictureBox[4, 4];

        private int score;

        public Form1()
        {
            InitializeComponent();
            KeyDown += OnKeyboardPressed;
            map[0, 0] = 1;
            map[0, 1] = 1;
            CreateMap(); // gray map
            CreatePics(); // color squares
            GenerateNewPic();
        }

        private void CreateMap()
        {
            for (var i = 0; i < 4; i++)
            for (var j = 0; j < 4; j++)
            {
                var pic = new PictureBox
                {
                    Location = new Point(12 + 56 * j, 73 + 56 * i),
                    Size = new Size(50, 50),
                    BackColor = ColorTranslator.FromHtml("#ccc1b5")
                };
                Controls.Add(pic);
            }
        }

        private void GenerateNewPic()
        {
            var rnd = new Random();
            var a = rnd.Next(0, 4);
            var b = rnd.Next(0, 4);
            while (pics[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }

            map[a, b] = 1;
            pics[a, b] = new PictureBox();
            labels[a, b] = new Label
            {
                Text = "2",
                Size = new Size(50, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(new FontFamily("Microsoft Sans Serif"), 15)
            };
            pics[a, b].Controls.Add(labels[a, b]);
            pics[a, b].Location = new Point(12 + b * 56, 73 + 56 * a);
            pics[a, b].Size = new Size(50, 50);
            pics[a, b].BackColor = ColorTranslator.FromHtml("#ede4db");
            Controls.Add(pics[a, b]);
            pics[a, b].BringToFront();
        }

        private void CreatePics()
        {
            pics[0, 0] = new PictureBox();
            labels[0, 0] = new Label
            {
                Text = "2",
                Size = new Size(50, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(new FontFamily("Microsoft Sans Serif"), 15)
            };
            pics[0, 0].Controls.Add(labels[0, 0]);
            pics[0, 0].Location = new Point(12, 73);
            pics[0, 0].Size = new Size(50, 50);
            pics[0, 0].BackColor = ColorTranslator.FromHtml("#ede4db");
            Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();

            pics[0, 1] = new PictureBox();
            labels[0, 1] = new Label
            {
                Text = "2",
                Size = new Size(50, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(new FontFamily("Microsoft Sans Serif"), 15)
            };
            pics[0, 1].Controls.Add(labels[0, 1]);
            pics[0, 1].Location = new Point(68, 73);
            pics[0, 1].Size = new Size(50, 50);
            pics[0, 1].BackColor = ColorTranslator.FromHtml("#ede4db");
            Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();
        }

        private void ChangeColor(int sum, int k, int j)
        {
            if (sum % 1024 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#edc53f");
            else if (sum % 512 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#edc850");
            else if (sum % 256 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#edcb60");
            else if (sum % 128 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#f65e3b");
            else if (sum % 64 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#f65e3b");
            else if (sum % 32 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#f97962");
            else if (sum % 16 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#eb9b6b");
            else if (sum % 8 == 0) pics[k, j].BackColor = ColorTranslator.FromHtml("#ebb37f");
            else pics[k, j].BackColor = ColorTranslator.FromHtml("#ece0cc");
        }

        private void OnKeyboardPressed(object sender, KeyEventArgs e)
        {
            var ifPicWasMoved = false;
            
            if (PicsFull())
            {
                var res = MessageBox.Show("Игра окончена! Хотите начать сначала?", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    score = 0;
                    label1.Text = "Score: " + score;
                    for (var i = 0; i < 4; i++)
                    {
                        for (var j = 0; j < 4; j++)
                        {
                            Controls.Remove(pics[i, j]);
                            Controls.Remove(labels[i, j]);
                            map[i, j] = 0;
                            labels[i, j] = null;
                            pics[i, j].Invalidate();
                            pics[i, j] = null;
                        }
                    }

                    map[0, 0] = 1;
                    map[0, 1] = 1;
                    CreateMap(); // gray map
                    CreatePics(); // color squares
                    GenerateNewPic();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                switch (e.KeyCode.ToString())
                {
                    case "Right":
                        for (var k = 0; k < 4; k++)
                        for (var l = 2; l >= 0; l--)
                            if (map[k, l] == 1)
                                for (var j = l + 1; j < 4; j++)
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        labels[k, j] = labels[k, j - 1];
                                        labels[k, j - 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 56,
                                            pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        var a = int.Parse(labels[k, j].Text);
                                        var b = int.Parse(labels[k, j - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += a + b;
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "Score: " + score;
                                            map[k, j - 1] = 0;
                                            Controls.Remove(pics[k, j - 1]);
                                            Controls.Remove(labels[k, j - 1]);
                                            pics[k, j - 1] = null;
                                            labels[k, j - 1] = null;
                                        }
                                    }

                        break;
                    case "Left":
                        for (var k = 0; k < 4; k++)
                        for (var l = 1; l < 4; l++)
                            if (map[k, l] == 1)
                                for (var j = l - 1; j >= 0; j--)
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        labels[k, j] = labels[k, j + 1];
                                        labels[k, j + 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 56,
                                            pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        var a = int.Parse(labels[k, j].Text);
                                        var b = int.Parse(labels[k, j + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += a + b;
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "Score: " + score;
                                            map[k, j + 1] = 0;
                                            Controls.Remove(pics[k, j + 1]);
                                            Controls.Remove(labels[k, j + 1]);
                                            pics[k, j + 1] = null;
                                            labels[k, j + 1] = null;
                                        }
                                    }

                        break;
                    case "Down":
                        for (var k = 2; k >= 0; k--)
                        for (var l = 0; l < 4; l++)
                            if (map[k, l] == 1)
                                for (var j = k + 1; j < 4; j++)
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        labels[j, l] = labels[j - 1, l];
                                        labels[j - 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X,
                                            pics[j, l].Location.Y + 56);
                                    }
                                    else
                                    {
                                        var a = int.Parse(labels[j, l].Text);
                                        var b = int.Parse(labels[j - 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += a + b;
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "Score: " + score;
                                            map[j - 1, l] = 0;
                                            Controls.Remove(pics[j - 1, l]);
                                            Controls.Remove(labels[j - 1, l]);
                                            pics[j - 1, l] = null;
                                            labels[j - 1, l] = null;
                                        }
                                    }

                        break;
                    case "Up":
                        for (var k = 1; k < 4; k++)
                        for (var l = 0; l < 4; l++)
                            if (map[k, l] == 1)
                                for (var j = k - 1; j >= 0; j--)
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        labels[j, l] = labels[j + 1, l];
                                        labels[j + 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X,
                                            pics[j, l].Location.Y - 56);
                                    }
                                    else
                                    {
                                        var a = int.Parse(labels[j, l].Text);
                                        var b = int.Parse(labels[j + 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += a + b;
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "Score: " + score;
                                            map[j + 1, l] = 0;
                                            Controls.Remove(pics[j + 1, l]);
                                            Controls.Remove(labels[j + 1, l]);
                                            pics[j + 1, l] = null;
                                            labels[j + 1, l] = null;
                                        }
                                    }

                        break;
                }

                if (ifPicWasMoved)
                    GenerateNewPic();
            }
        }

        private bool PicsFull()
        {
            for (var i = 0; i < 4; ++i)
            {
                for (var j = 0; j < 4; ++j)
                {
                    if (pics[i, j] == null) return false; // false если есть пустые клетки
                    if (labels[i, j].Text == "2048") return true;
                }
            }

            return !CanStack();
        }

        private bool CanStack()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 3)
                        if (labels[i, j].Text == labels[i + 1, j].Text)
                            return true;
                    if (i > 0)
                        if (labels[i, j].Text == labels[i - 1, j].Text)
                            return true;
                    if (j > 0)
                        if (labels[i, j].Text == labels[i, j - 1].Text)
                            return true;
                    if (j < 3)
                        if (labels[i, j].Text == labels[i, j + 1].Text)
                            return true;
                }
            }

            return false; // если все попарно разные
        }
    }
}