using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lesson3_1
{
    public partial class Form1 : Form
    {
        private static bool paint;
        private static int X;
        private static int Y;
        private SolidBrush backBrush;
        private Pen BackColorPen;
        private Pen Blackpen;
        private Bitmap bmp;
        private Bitmap bmp2;
        private Pen mainpen;
        private ValueType StartPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pictureBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainpen = new Pen(Color.Black, 3f);
            Blackpen = new Pen(Color.Black, 1f);
            backBrush = new SolidBrush(pictureBox1.BackColor);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            BackColorPen = new Pen(pictureBox1.BackColor, 1f);
            X = pictureBox1.Width;
            Y = pictureBox1.Height;
            pictureBox1.CreateGraphics();
            Graphics.FromImage(bmp).Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
                return;
            bmp2 = new Bitmap(Math.Max(pictureBox1.Width, X),
                Math.Max(pictureBox1.Height, Y));
            var rect = new Rectangle(0, 0, Math.Max(pictureBox1.Width, X),
                Math.Max(pictureBox1.Height, Y));
            var pixelFormat = bmp2.PixelFormat;

            pictureBox1.CreateGraphics();
            var graphics = Graphics.FromImage(bmp2);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (bmp != null)
                graphics.DrawImage(bmp, 0, 0, Math.Max(pictureBox1.Width, X),
                    Math.Max(pictureBox1.Height, Y));

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = bmp2.Clone(rect, pixelFormat);
            graphics.DrawImage(bmp, 0, 0, pictureBox1.Width, pictureBox1.Height);
            X = pictureBox1.Width;
            Y = pictureBox1.Height;
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            var solidBrush1 = new SolidBrush(Color.Red);
            var solidBrush2 = new SolidBrush(Color.Blue);
            var solidBrush3 = new SolidBrush(Color.Yellow);
            var solidBrush4 = new SolidBrush(Color.Green);
            if (pictureBox2.Height <= 3)
                return;
            e.Graphics.FillRectangle(solidBrush3, 0, 0, pictureBox2.Width,
                (int) Math.Floor(pictureBox2.Height / 4.0));
            e.Graphics.FillRectangle(solidBrush4, 0,
                (int) (Math.Floor(pictureBox2.Height / 4.0) + 1.0), pictureBox2.Width,
                (int) Math.Floor(pictureBox2.Height / 2.0));
            e.Graphics.FillRectangle(solidBrush2, 0,
                (int) (Math.Floor(pictureBox2.Height / 2.0) + 1.0), pictureBox2.Width,
                (int) Math.Floor(pictureBox2.Height * 3.0 / 4));
            e.Graphics.FillRectangle(solidBrush1, 0,
                (int) (Math.Floor(pictureBox2.Height * 3.0 / 4) + 1.0), pictureBox2.Width,
                pictureBox2.Height);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                var bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                var targetBounds = new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height);
                pictureBox2.DrawToBitmap(bitmap, targetBounds);
                mainpen.Color = bitmap.GetPixel(e.X, e.Y);
            }

            if (MouseButtons != MouseButtons.Right)
                return;
            mainpen.Color = Color.Black;
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (mainpen.Width <= 20.0)
                    ++mainpen.Width;
                else
                    MessageBox.Show("Достигнут максимальный размер кисти");
            }
            else if (mainpen.Width >= 2.0)
            {
                --mainpen.Width;
            }
            else
            {
                MessageBox.Show("Достигнут минимальный размер кисти");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.CreateGraphics();
            Graphics.FromImage(bmp).Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа для рисования.\nНажмите и удерживайте левую кнопку мыши для рисования. \nНажмите и удерживайте правую кнопку для стирания нарисованного.\nКолесико мыши позволяет регулировать размер кисти.\nНажатие левой кнопки мыши в области политры задает цвет кисти.\nНажатие правой кнопки мыши в области политры возвращает цвет кисти заданный по умолчанию.",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void загрузитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Открыть картинку в формате ...",
                CheckFileExists = true,
                Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.JPG|" +
                         "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png",
                ShowHelp = false
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var fileName = openFileDialog.FileName;
            pictureBox1.Load(fileName);
            bmp2 = new Bitmap(Image.FromFile(fileName));

            bmp = new Bitmap(X, Y);
            pictureBox1.CreateGraphics();
            var graphics = Graphics.FromImage(bmp);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var white = Color.White;
            graphics.Clear(white);
            
            if (pictureBox1.Image != null)
                graphics.DrawImage(pictureBox1.Image, 0, 0, X, Y);
            pictureBox1.Image = bmp;
        }

        private void сохранитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Title = "Сохранить картинку как ...",
                OverwritePrompt = true,
                CheckPathExists = true,
                Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" +
                         "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png",
                ShowHelp = true,
                AddExtension = true
            };

            var res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK) bmp.Save($"{saveFileDialog.FileName}", ImageFormat.Jpeg);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            paint = true;
            StartPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!paint)
                return;
            if (MouseButtons == MouseButtons.Left)
            {
                Cursor.Show();
                var graphics = Graphics.FromImage(bmp);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawLine(mainpen, ((Point) StartPoint).X, ((Point) StartPoint).Y, e.X, e.Y);
                graphics.DrawImage(bmp, 0, 0);
                StartPoint = e.Location;
                pictureBox1.Invalidate();
            }
            else
            {
                Cursor.Hide();
                var graphics1 = Graphics.FromImage(bmp);
                Blackpen.Width = 1f;
                Blackpen.Color = Color.Black;

                graphics1.FillRectangle(backBrush, ((Point) StartPoint).X - 2,
                    ((Point) StartPoint).Y - 2, 10, 10);
                graphics1.DrawRectangle(BackColorPen, ((Point) StartPoint).X - 2, ((Point) StartPoint).Y - 2,
                    10, 10);
                graphics1.DrawRectangle(Blackpen, e.X - 2, e.Y - 2, 10, 10);
                graphics1.DrawImage(bmp, 0, 0);

                StartPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Show();
            paint = false;
            Cursor.Show();
            var graphics = Graphics.FromImage(bmp);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (mainpen != null)
                graphics?.DrawLine(mainpen, ((Point) StartPoint).X, ((Point) StartPoint).Y, e.X, e.Y);
            if (BackColorPen != null)
            {
                graphics?.DrawRectangle(BackColorPen, ((Point) StartPoint).X - 2,
                    ((Point) StartPoint).Y - 2, 10, 10);
            }

            pictureBox1.Invalidate();
        }
    }
}