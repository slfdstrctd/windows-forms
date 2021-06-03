using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // panel1.Controls.Clear();
            panel1.Visible = true;

            switch (e.Node.Index)
            {
                case 0: // wipe
                    panel1.Visible = false;
                    panel1.Controls.Clear();
                    break;
                case 1: // label
                    label1 = new Label();
                    label1.Text = "This is a label. Labels are simply used to write text at a point on the screen";
                    label1.Location = new Point(400, 50);
                    label1.Size = new Size(150, 80);
                    panel1.Controls.Add(label1);
                    break;
                case 2: // button
                    button1 = new Button();
                    button1.Text = "Кнопка";
                    button1.Location = new System.Drawing.Point(250, 50);
                    button1.Size = new System.Drawing.Size(106, 29);
                    button1.Click += button1_Click;
                    // button1.Show();
                    panel1.Controls.Add(button1);
                    break;
                case 3: // checkbox
                    checkBox1 = new CheckBox();
                    checkBox1.Text = "I am sharp";
                    checkBox1.Location = new Point(40, 50);
                    checkBox1.Size = new Size(150, 25);
                    checkBox1.CheckedChanged += checkBox_CheckedChanged;

                    panel1.Controls.Add(checkBox1);

                    checkBox2 = new CheckBox();
                    checkBox2.Text = "I am modest";
                    checkBox2.Location = new Point(40, 80);
                    checkBox2.Size = new Size(150, 25);
                    checkBox2.CheckedChanged += checkBox_CheckedChanged;

                    panel1.Controls.Add(checkBox2);
                    break;
                case 4: // radio
                    radioButton1 = new RadioButton();
                    radioButton1.Text = "I am sharp";
                    radioButton1.Location = new Point(200, 140);
                    radioButton1.Size = new Size(150, 40);
                    radioButton1.CheckedChanged += radioButton_CheckedChanged;

                    panel1.Controls.Add(radioButton1);

                    radioButton2 = new RadioButton();
                    radioButton2.Text = "I am dim-witted";
                    radioButton2.Location = new Point(200, 170);
                    radioButton2.Size = new Size(150, 40);
                    radioButton2.CheckedChanged += radioButton_CheckedChanged;

                    panel1.Controls.Add(radioButton2);
                    break;
                case 5: // list
                    listBox1 = new ListBox();
                    listBox1.Items.Add("Green");
                    listBox1.Items.Add("Beige");
                    listBox1.Items.Add("White");
                    listBox1.Location = new Point(40, 150);
                    listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

                    panel1.Controls.Add(listBox1);
                    break;
                case 6: // textbox
                    textBox1 = new TextBox();
                    textBox1.Text = "You can type here";
                    textBox1.Size = new Size(150, 30);
                    textBox1.Location = new Point(250, 90);
                    
                    panel1.Controls.Add(textBox1);
                    break;
                case 7: // tabctrl
                    
                    tabPage1.Text = "MyHome";
                    var pictureBox2 = new PictureBox();
                    pictureBox2.Image =
                        new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/MyHome.JPG");
                    pictureBox2.Size = new Size(240, 160);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tabPage1.Controls.Add(pictureBox2);

                    tabPage2.Text = "MyHome2";
                    var pictureBox3 = new PictureBox();
                    pictureBox3.Image =
                        new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/MyHome2.JPG");
                    pictureBox3.Size = new Size(240, 160);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    tabPage2.Controls.Add(pictureBox3);

                    tabPage3.Text = "MyHome3";
                    var pictureBox4 = new PictureBox();
                    pictureBox4.Image =
                        new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/MyHome3.JPG");
                    pictureBox4.Size = new Size(240, 160);
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    tabPage3.Controls.Add(pictureBox4);

                    tabPage4.Text = "Info";
                    tabPage4.BackColor = Color.DarkGray;
                    var label2 = new Label();
                    label2.Text = "Live in St. Petersburg, Russia. \n\n" +
                                  "I have a beautiful vision from" +
                                  "my window at diffemt time of" +
                                  "day and night.";
                    label2.Dock = DockStyle.Fill;

                    tabPage4.Controls.Add(label2);

                    panel1.Controls.Add(tabControl1);
                    break;
                case 8: // datagrid
                    var dataSet1 = new DataSet("A sample dataset");
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    dataSet1.ReadXml("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/Example.xml");

                    dataGridView1.DataSource = dataSet1;
                    dataGridView1.DataMember = "subject";
                    dataGridView1.Size = new Size(300, 150);
                    panel1.Controls.Add(dataGridView1);
                    break;
                case 9: // menu
                    menuStrip1.Visible = true;

                    MessageBox.Show(
                        "A main menu has been added at the top left of the window. Try it out after clicking OK.");
                    
                    break;
                case 10: // toolstrip
                    toolStrip1 = new ToolStrip();
                    ImageList imageList1 = new ImageList();
                    imageList1.Images.Add(
                        new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/new.gif"));
                    imageList1.Images.Add(
                        new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/open.gif"));
                    imageList1.Images.Add(
                        new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/close.gif"));

                    toolStrip1.ImageList = imageList1;

                    toolStripButton1 = new ToolStripButton("New");
                    toolStripButton1.ImageIndex = 0;
                    toolStrip1.Items.Add(toolStripButton1);

                    toolStripButton2 = new ToolStripButton("Open");
                    toolStripButton2.ImageIndex = 1;
                    toolStrip1.Items.Add(toolStripButton2);

                    toolStripButton3 = new ToolStripButton("Save");
                    toolStripButton3.ImageIndex = 2;
                    toolStrip1.Items.Add(toolStripButton3);

                    toolStrip1.ItemClicked += ToolStrip1_ItemClicked;

                    panel1.Controls.Add(toolStrip1);
                    break;
                case 11: // pic
                    pictureBox1.Image = new Bitmap("C:/Users/slfdstrctd/RiderProjects/lesson2_1/lesson2_1/Lake.JPG");
                    pictureBox1.Size = new Size(240, 160);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel1.Controls.Add(pictureBox1);
                    break;
                case 12: // richtext
                    richTextBox1.LoadFile("../../../Example.xml", RichTextBoxStreamType.PlainText);
                    richTextBox1.WordWrap = false;
                    richTextBox1.BorderStyle = BorderStyle.Fixed3D;
                    richTextBox1.BackColor = Color.Beige;
                    panel1.Controls.Add(richTextBox1);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ох, зря вы меня нажали");
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
                MessageBox.Show("Good for you");
            else if (checkBox1.Checked)
                MessageBox.Show("It's not good to be sharp without being modest");
            else if (checkBox2.Checked)
                MessageBox.Show("Modesty is good. Petty you're not sharp too.");
            else
                MessageBox.Show("Oh dear, neither sharp nor modest eh?");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Glad to hear it");
            else if (radioButton2.Checked) MessageBox.Show("What a shame");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Green")
                treeView1.BackColor = Color.LightSeaGreen;
            else if (listBox1.SelectedItem.ToString() == "Beige")
                treeView1.BackColor = Color.Beige;
            else if (listBox1.SelectedItem.ToString() == "White") treeView1.BackColor = Color.White;
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo) ==
                DialogResult.Yes) Dispose();
        }

        private void chooseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var colorDialog1 = new ColorDialog();
            colorDialog1.Color = treeView1.BackColor;
            colorDialog1.ShowDialog();
            treeView1.BackColor = colorDialog1.Color;
        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.BackColor = Color.White;
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "New")
            {
                MessageBox.Show("This could have created a file, for example");
            }
            else if (e.ClickedItem.Text == "Open")
            {
                MessageBox.Show("This could have opened a file, for example");
            }
            else if (e.ClickedItem.Text == "Save")
            {
                MessageBox.Show("This could have saved a file, for example");
            }
        }
    }
}