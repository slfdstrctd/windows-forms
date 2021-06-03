using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace txtedit1
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem alignItem;

        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            alignItem = leftJustify1;
            leftJustify1.Tag = HorizontalAlignment.Left;
            center1.Tag = HorizontalAlignment.Left;
            rightJustify1.Tag = HorizontalAlignment.Right;
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToFile(string path)
        {
            var sw = new StreamWriter(path, false, Encoding.Default);

            sw.WriteLine(textBox1.Text);
            sw.Close();
            textBox1.Modified = false;
        }

        private bool TextSaved()
        {
            if (textBox1.Modified)
                switch (MessageBox.Show("Сохранить изменения в документе?", "Подтверждение",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))

                {
                    case DialogResult.Yes:
                        save1_Click(this, null);
                        return !textBox1.Modified;
                    case DialogResult.Cancel:
                        return false;
                }

            return true;
        }

        private void saveAs1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog1.FileName;
                SaveToFile(path);
                Text = "Text Editor - " + Path.GetFileName(path);
            }
        }

        private void save1_Click(object sender, EventArgs e)
        {
            string path = saveFileDialog1.FileName;
            if (path == "")
                saveAs1_Click(saveAs1, null);
            else
                SaveToFile(path);
        }

        private void new1_Click(object sender, EventArgs e)
        {
            if (TextSaved())
            {
                textBox1.Clear();
                Text = "Text Editor";
                saveFileDialog1.FileName = "";
            }
        }

        private void open1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path, Encoding.Default);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                Text = "Text Editor -" + Path.GetFileName(path);
                saveFileDialog1.FileName = path;
                openFileDialog1.FileName = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !TextSaved();
        }

        private void bold1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            mi.Checked = !mi.Checked;
            FontStyle fs = textBox1.Font.Style;
            fs = mi.Checked ? fs | mi.Font.Style : fs & ~mi.Font.Style;
            Font f = textBox1.Font;
            textBox1.Font = new Font(f, fs);
            f.Dispose();
        }

        private void leftJustify1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi.Checked) return;
            alignItem.Checked = false;
            alignItem = mi;
            mi.CheckState = CheckState.Indeterminate;
            textBox1.TextAlign = (HorizontalAlignment) mi.Tag;
        }

        private void fontColor1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textBox1.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void backgroundColor1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textBox1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        private void font1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!textBox1.Font.Equals(fontDialog1.Font))
                {
                    Font f = textBox1.Font;
                    textBox1.Font = fontDialog1.Font;
                    f.Dispose();
                    bold1.Checked = fontDialog1.Font.Bold;
                    italic1.Checked = fontDialog1.Font.Italic;
                    underline1.Checked = fontDialog1.Font.Underline;
                }
            }
        }

        private void undo1_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cut1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copy1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void paste1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void selectAll1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            undo1.Enabled = textBox1.CanUndo;
            cut1.Enabled = copy1.Enabled = delete1.Enabled =
                textBox1.SelectionLength > 0;
            paste1.Enabled =
                Clipboard.GetDataObject().GetDataPresent(typeof(string));
            selectAll1.Enabled = textBox1.Text != "";
        }

        private void contextMenuStrip1_Opening(object senser, EventArgs e)
        {
            cut2.Enabled = copy2.Enabled = textBox1.SelectionLength > 0;
            paste2.Enabled = Clipboard.GetDataObject().GetDataPresent(typeof(string));
        }
    }
}