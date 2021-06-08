using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using fourth.Properties;

namespace fourth
{
    public partial class Form1 : Form
    {
        private readonly TextureBrush brsh = new TextureBrush(Resources.Asphalt);
        private Bitmap canvas;
        private int choice;
        private Pic chosen;
        private bool clicked;
        private Bitmap currbmp;
        private bool draw;
        private int drx, dry;
        private int index;
        private readonly List<Pic> map = new List<Pic>();
        private bool moved;
        private int x, y;

        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            foreach (Control c in Controls)
                if ((c.GetType().ToString() == "System.Windows.Forms.Button") & (c.Name != "button10") &
                    (c.Name != "button11") & (c.Name != "Asphalt") & (c.Name != "button1"))
                {
                    try
                    {
                        var cc = (Button) c;
                        c.MouseClick += (sender, e) =>
                        {
                            label2.Text = c.Name;
                            currbmp = (Bitmap) cc.Image;
                            index = cc.ImageIndex;
                            draw = false;
                        };
                    }
                    catch (Exception)
                    {
                    }
                }
                else if ((c.GetType().ToString() == "System.Windows.Forms.Button") & (c.Name == "Asphalt"))
                {
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) & !draw)
                if (currbmp != null)
                {
                    map.Add(new Pic(currbmp,
                        new Rectangle(e.X - currbmp.Width / 2, e.Y - currbmp.Height / 2, currbmp.Width, currbmp.Height),
                        index));
                    pictureBox1.Invalidate();
                }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                x = e.X;
                y = e.Y;
                if (map.Find(inter) != null)
                {
                    moved = true;
                    chosen = map.Find(inter);
                }
            }
            else if (draw)
            {
                clicked = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moved = false;
            if (draw) clicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moved)
            {
                chosen.rct.X = e.X - chosen.bm.Width / 2;
                chosen.rct.Y = e.Y - chosen.bm.Height / 2;
                ;
                pictureBox1.Invalidate();
            }

            //bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // pictureBox1.DrawToBitmap(bm, pictureBox1.ClientRectangle);
            if (draw & clicked)
            {
                var im = Graphics.FromImage(canvas);
                im.FillEllipse(brsh, e.X - 15, e.Y - 15, 40, 40);
                pictureBox1.Image = canvas;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var pic in map) e.Graphics.DrawImage(pic.bm, pic.rct);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (map.Count != 0)
                map.RemoveAt(map.Count - 1);
            draw = false;
            pictureBox1.Invalidate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            map.Clear();
            draw = false;
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas;
            pictureBox1.Invalidate();
        }

        private void сохранитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var savefile = new SaveFileDialog();
            savefile.OverwritePrompt = true;
            //отображать ли предупреждение, если пользователь указывает несуществующий путь
            savefile.CheckPathExists = true;
            savefile.Filter = "PNG files(*.png) | *.png";
            if (savefile.ShowDialog() == DialogResult.Cancel)
                return;

            var savedBit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(savedBit, pictureBox1.ClientRectangle);
            savedBit.Save(savefile.FileName, ImageFormat.Png);
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openfile = new OpenFileDialog();
            openfile.Filter = "PNG files(*.png) | *.png";
            if (openfile.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1.Image = new Bitmap(openfile.FileName);
            map.Clear();
            canvas = new Bitmap(openfile.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw = false;
            var SavePath = Application.StartupPath;
            SavePath = Environment.CurrentDirectory;
            Directory.CreateDirectory(SavePath + "\\Save\\");
            SavePath = SavePath + "\\Save\\";
            try
            {
                //canvas.Save(fs, System.Drawing.Imaging.ImageFormat.Png);

                canvas.Save(SavePath + "CitySave.bmp", ImageFormat.Png);


                // System.Xml.XmlWriter xmlWriter;

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineOnAttributes = true;

                using (var xmlWriter = XmlWriter.Create(SavePath + "CitySave.xml", settings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("CityDesign");
                    foreach (var c in map)
                    {
                        xmlWriter.WriteStartElement("Object");
                        xmlWriter.WriteAttributeString("X", c.rct.X.ToString());
                        xmlWriter.WriteAttributeString("Y", c.rct.Y.ToString());
                        xmlWriter.WriteAttributeString("id", c.index.ToString());
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                }

                //xmlWriter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    //"Ошибка доступа к файлу.\n" +
                    SavePath + "\n",
                    //"City",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void прошлыйСеансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = XmlReader.Create(Application.StartupPath + "\\Save\\CitySave.xml");
                map.Clear();
                while (reader.Read())
                    if (reader.IsStartElement() & (reader.Name == "Object"))
                    {
                        var x = int.Parse(reader.GetAttribute("X"));
                        var y = int.Parse(reader.GetAttribute("Y"));
                        var ind = int.Parse(reader.GetAttribute("id"));
                        var pc = (Bitmap) imageList1.Images[ind];
                        map.Add(new Pic(pc, new Rectangle(x, y, pc.Width, pc.Height), ind));
                    }

                reader.Close();
                reader.Dispose();
                using (var fs = File.OpenRead(Environment.CurrentDirectory + "\\Save\\CitySave.bmp"))
                {
                    canvas = new Bitmap(fs);
                }

                pictureBox1.Image = canvas;
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
            }
        }

        private void Asphalt_Click(object sender, EventArgs e)
        {
            draw = true;
            label2.Text = Asphalt.Name;
        }

        private bool inter(Pic pc)
        {
            if (pc.rct.Contains(x, y)) return true;
            return false;
        }
    }

    public class Pic
    {
        public Bitmap bm;
        public int index;
        public Rectangle rct;

        public Pic(Bitmap bp, Rectangle rc, int id)
        {
            bm = bp;
            rct = rc;
            index = id;
        }
    }
}