using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private string curItemName = string.Empty;
        private Bitmap currImage;
        private readonly List<Picture> imageList = new List<Picture>();
        private bool isBrush;

        private bool isPaint;

        private readonly TextureBrush tBrush = new TextureBrush(Resources.Asphalt);

        public Form1()
        {
            InitializeComponent();

            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            foreach (Control c in Controls)
                if (c.GetType().ToString() == "System.Windows.Forms.Button")
                    c.MouseClick += (sender, e) => { label2.Text = curItemName; };

            pictureBox1.BackColor = Color.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currImage = Resources.Property;
            isBrush = false;
            curItemName = "Жилой дом";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currImage = Resources.office_building;
            isBrush = false;
            curItemName = "Офисный центр";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currImage = Resources.Filming_Studio_SW;
            isBrush = false;
            curItemName = "Развлекательный центр";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currImage = Resources.industry;
            isBrush = false;
            curItemName = "Фабрика";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currImage = Resources.Kensington_Hall_SW;
            isBrush = false;
            curItemName = "Центральная библиотека";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currImage = Resources.stadium_icon;
            isBrush = false;
            curItemName = "Стадион";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currImage = Resources.Apple_Tree_Big_icon2;
            isBrush = false;
            curItemName = "Дерево1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currImage = Resources.Oak_Sapling_icon;
            isBrush = false;
            curItemName = "Дерево2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            isBrush = true;
            curItemName = "Дорога";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                imageList.RemoveAt(imageList.Count - 1);
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            imageList.Clear();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isBrush)
                try
                {
                    imageList.Add(new Picture(currImage, new Rectangle(e.X - currImage.Size.Width / 4,
                        e.Y - currImage.Size.Height / 4,
                        currImage.Size.Width / 2,
                        currImage.Size.Height / 2)));
                    pictureBox1.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint && isBrush)
            {
                var g = Graphics.FromImage(canvas);
                g.FillEllipse(tBrush, e.X - 20, e.Y - 20, 40, 40);
                pictureBox1.Image = canvas;
                g.Dispose();
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in imageList) e.Graphics.DrawImage(item._btm, item._rect);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var SavePath = Application.StartupPath;
            SavePath = Environment.CurrentDirectory;
            Directory.CreateDirectory(SavePath + "\\Save\\");
            SavePath = SavePath + "\\Save\\";
            try
            {
                canvas.Save(SavePath + "CitySave.bmp", ImageFormat.Bmp);

                XmlWriter xmlWriter;

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineOnAttributes = true;
                xmlWriter = XmlWriter.Create(SavePath + "CitySave.xml", settings);

                //xmlWriter.WriteStartDocument();
                //
                //...
                //   
                //xmlWriter.WriteEndDocument();
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
    }
}