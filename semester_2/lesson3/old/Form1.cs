using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lesson3
{
    public partial class Form1 : Form
    {
        private readonly Pen pen1 = new Pen(Color.Black, 3);
        private bool created, paint, opened;

        private Graphics g, gimg;

        private Image img;
        private Image img2;
        private Point startPoint, endPoint;

        public Form1()
        {
            InitializeComponent();

            g = panelMain.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private int PanelWidth { get; set; }
        private int PanelHeight { get; set; }


        private void ChangeColor(object sender, MouseEventArgs e)
        {
            pen1.Color = e.Button == MouseButtons.Right ? Color.Black : ((Panel) sender).BackColor;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            if (img == null)
            {
                img = new Bitmap(PanelWidth, PanelHeight, g);    
                gimg = Graphics.FromImage(img);
                gimg.SmoothingMode = SmoothingMode.AntiAlias;
                gimg.Clear(Color.White);
            }

            e.Graphics.DrawImage(img, new Rectangle(0, 0, PanelWidth, PanelHeight));
        }

        private void panelMain_Resize(object sender, EventArgs e)
        {
            PanelWidth = panelMain.Width;
            PanelHeight = panelMain.Height;
            if (img != null && WindowState != FormWindowState.Minimized)
            {
                img2 = new Bitmap(PanelWidth, PanelHeight, g);
                gimg = Graphics.FromImage(img2);
                gimg.SmoothingMode = SmoothingMode.AntiAlias;
                gimg.Clear(Color.White);
                gimg.DrawImage(img, 0, 0);
                g = panelMain.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                img = img2;
            }
        }

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (created)
            {
                paint = true;
                startPoint = new Point(e.X, e.Y);
            }
            else
            {
                paint = true;
                created = true;
                startPoint = new Point(e.X, e.Y);
                pen1.EndCap = pen1.StartCap = LineCap.Round;
            }
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (img == null) return;
            endPoint = new Point(e.X, e.Y);
            if (paint)
            {
                var c = pen1.Color;
                if (e.Button == MouseButtons.Right) pen1.Color = Color.White;

                gimg.DrawLine(pen1, startPoint, endPoint);
                g.DrawLine(pen1, startPoint, endPoint);
                startPoint = endPoint;
                pen1.Color = c;
            }
        }

        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (opened)
            {
                opened = false;
                return;
            }

            paint = false;
            g.DrawImage(img, 0, 0);
        }

        private void panelMain_MouseWheel(object sender, MouseEventArgs e)
        {
            pen1.Width += (float) 0.001 * SystemInformation.MouseWheelScrollLines * e.Delta;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                g.Clear(Color.White);
                gimg.Clear(Color.White);

                gimg = Graphics.FromImage(img2);
                g = panelMain.CreateGraphics();

                g.SmoothingMode = SmoothingMode.AntiAlias;
                gimg.SmoothingMode = SmoothingMode.AntiAlias;

                gimg.DrawImage(img2, 0, 0);
                g.DrawImage(img2, 0, 0);
                img = img2;
                panelMain_Resize(sender, e);
            }

            opened = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!created) return;
            panelMain.Refresh();
            gimg.Clear(Color.White);
            g.Clear(Color.White);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Фаил картинки в формате JPG|*.jpg  |Фаил картинки в формате PNG|*.png";
            var res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK) img.Save($"{saveFileDialog1.FileName}", ImageFormat.Jpeg);
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для рисования.\nНажмите и удерживайте левую кнопку мыши для рисования.\n" +
                            "Нажмите и удерживайте правую кнопку для стирания нарисованного.\n" +
                            "Колесико мыши позволяет регулировать размер кисти.\n" +
                            "Нажатие левой кнопки мыши в области палитры задает цвет кисти.\n" +
                            "Нажатие правой кнопки мыши в области палитры возвращает цвет кисти заданный по умолчанию.\n",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}