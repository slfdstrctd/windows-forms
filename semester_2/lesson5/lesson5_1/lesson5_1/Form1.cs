using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace lesson5_1
{
    public partial class Form1 : Form
    {
        string fpath;
        string fname;
        XmlReader xmlReader;
        string qw;
        string[] answ = new string[3];
        string pic;

        int right;
        int otv;
        int n;
        int nv;
        int mode;


        public Form1(string[] args)
        {
            InitializeComponent();

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton4.Visible = false;

            if (args.Length > 0)
            {
                if (args[0].IndexOf(";") == -1)
                {
                    fpath = Application.StartupPath + "\\";
                    fname = args[0];
                }
                else
                {
                    fpath = args[0].Substring(0, args[0].LastIndexOf("\\") + 1);
                    fname = args[0].Substring(args[0].LastIndexOf("\\") + 1);
                }

                try
                {
                    xmlReader = new XmlTextReader(fpath + fname);
                    xmlReader.Read();
                    mode = 0;
                    n = 0;
                    showHead();
                    showDescription();
                }
                catch
                {
                    label1.Text = "Ошибка доступа к файлу " + fpath + fname;
                    MessageBox.Show("Ошибка доступа к файлу.\n" + fpath + fname + "\n", "Экзаменатор",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mode = 2;
                }
            }
            else
            {
                label1.Text =
                    "Файл теста необходимо указать в команде запуска программы.\n Например: 'exam economics.xml' или 'exam c:\\spb.xml'.";
                mode = 2;
            }
        }

        private void showHead()
        {
            do xmlReader.Read();
            while (xmlReader.Name != "head");
            xmlReader.Read();
            this.Text = xmlReader.Value;
            xmlReader.Read();
        }

        private void showDescription()
        {
            do xmlReader.Read();
            while (xmlReader.Name != "description");
            xmlReader.Read();
            label1.Text = xmlReader.Value;
            xmlReader.Read();
            do xmlReader.Read();
            while (xmlReader.Name != "qw");
            xmlReader.Read();
        }

        private Boolean getQw()
        {
            xmlReader.Read();
            if (xmlReader.Name == "q")
            {
                qw = xmlReader.GetAttribute("text");
                pic = xmlReader.GetAttribute("src");
                if (!pic.Equals(string.Empty)) pic = fpath = pic;
                xmlReader.Read();
                int i = 0;
                while (xmlReader.Name != "q")
                {
                    xmlReader.Read();
                    if (xmlReader.Name == "a")
                    {
                        if (xmlReader.GetAttribute("right") == "yes") right = i;
                        xmlReader.Read();
                        if (i < 3) answ[i] = xmlReader.Value;
                        xmlReader.Read();
                        i++;
                    }
                }

                xmlReader.Read();
                return true;
            }
            else return false;
        }

        private void showQw()
        {
            label1.Text = qw;
            if (pic.Length != 0)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(pic);
                    pictureBox1.Visible = true;
                    radioButton1.Top = pictureBox1.Bottom + 16;
                }
                catch
                {
                    if (pictureBox1.Visible)
                    {
                        pictureBox1.Visible = false;
                        label1.Text += "\n\n\nОшибка доступа к файлу " + pic + "/";
                        radioButton1.Top = label1.Bottom + 8;
                    }
                }
            }

            else
            {
                if (pictureBox1.Visible) pictureBox1.Visible = false;
                radioButton1.Top = label1.Bottom;
            }

            radioButton1.Text = answ[0];
            radioButton2.Top = radioButton1.Top + 24;
            radioButton2.Text = answ[1];
            radioButton4.Top = radioButton2.Top + 24;
            radioButton4.Text = answ[2];

            radioButton3.Checked = true;
            button1.Enabled = false;
        }

        private void showLevel()
        {
            do xmlReader.Read();
            while (xmlReader.Name != "levels");
            xmlReader.Read();
            while (xmlReader.Name != "levels")
            {
                xmlReader.Read();
                if (xmlReader.Name == "level")
                    if (n >= Convert.ToInt32(xmlReader.GetAttribute("score")))
                        break;
            }

            label1.Text = "Тестирование завершено.\n" + "Всего вопросов: " + nv.ToString() + ". " +
                          "Правильных ответов: " + n.ToString() + ".\n" +
                          xmlReader.GetAttribute("text");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:

                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton4.Visible = true;
                    getQw();
                    showQw();
                    mode = 1;
                    button1.Enabled = false;
                    radioButton3.Checked = true;
                    button1.Text = "Ok";
                    break;
                case 1:
                    nv++;
                    if (otv == right) n++;
                    if (getQw()) showQw();
                    else
                    {
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton4.Visible = false;
                        pictureBox1.Visible = false;
                        showLevel();
                        mode = 2;
                    }

                    break;
                case 2:
                    Close();
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((RadioButton) sender == radioButton1) otv = 0;
            if ((RadioButton) sender == radioButton2) otv = 1;
            if ((RadioButton) sender == radioButton3) otv = 2;
            button1.Enabled = true;
        }
    }
}