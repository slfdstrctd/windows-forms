using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace txtedit2
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem alignItem;
        private readonly Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            alignItem = leftJustify1;
            leftJustify1.Tag = HorizontalAlignment.Left;
            center1.Tag = HorizontalAlignment.Center;
            rightJustify1.Tag = HorizontalAlignment.Right;
            timer1_Tick(this, null);
            file1.DropDown.ShowItemToolTips = false;
            AddOwnedForm(form2);
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToFile(string path)
        {
            // var sw = new StreamWriter(path, false, Encoding.Default);
            //
            // sw.WriteLine(textBox1.Text);
            // sw.Close();
            textBox1.SaveFile(path, GetFileType(path));
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
            if (TextSaved())
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    // StreamReader sr = new StreamReader(path, Encoding.Default);
                    // textBox1.Text = sr.ReadToEnd();
                    // sr.Close();
                    textBox1.LoadFile(path, GetFileType(path));
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
            FontStyle fs = textBox1.SelectionFont.Style;
            fs = mi.Checked ? fs | mi.Font.Style : fs & ~mi.Font.Style;
            Font f = textBox1.SelectionFont;
            textBox1.SelectionFont = new Font(f, fs);
            f.Dispose();
            ToolStripButton sb = GetButton(mi);
            sb.Checked = !sb.Checked;
        }

        private void leftJustify1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi.Checked) return;
            GetButton(alignItem).Checked = alignItem.Checked = false;
            alignItem = mi;
            mi.CheckState = CheckState.Indeterminate;
            GetButton(mi).Checked = true;
            textBox1.SelectionAlignment = (HorizontalAlignment) mi.Tag;
        }

        private void fontColor1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.SelectionColor = colorDialog1.Color;
        }

        private void backgroundColor1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textBox1.SelectionBackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void font1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!textBox1.SelectionFont.Equals(fontDialog1.Font))
                {
                    Font f = textBox1.SelectionFont;
                    textBox1.SelectionFont = fontDialog1.Font;
                    f.Dispose();
                    bold10.Checked = bold1.Checked = fontDialog1.Font.Bold;
                    italic10.Checked = italic1.Checked = fontDialog1.Font.Italic;
                    underline10.Checked = underline1.Checked = fontDialog1.Font.Underline;
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

        private ToolStripButton GetButton(ToolStripMenuItem mi)
        {
            return toolStrip1.Items[mi.Name + "0"] as ToolStripButton;
        }

        private void bold10_Click(object sender, EventArgs e)
        {
            bold1_Click(bold1, null);
        }

        private void italic10_Click(object sender, EventArgs e)
        {
            bold1_Click(italic1, null);
        }

        private void underline10_Click(object sender, EventArgs e)
        {
            bold1_Click(underline1, null);
        }

        private void leftJustify10_Click(object sender, EventArgs e)
        {
            leftJustify1_Click(leftJustify1, null);
        }

        private void center10_Click(object sender, EventArgs e)
        {
            leftJustify1_Click(center1, null);
        }

        private void rightJustify10_Click(object sender, EventArgs e)
        {
            leftJustify1_Click(rightJustify1, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cap1.Text = Control.IsKeyLocked(Keys.CapsLock) ? "CAP" : "";
            num1.Text = Control.IsKeyLocked(Keys.NumLock) ? "NUM" : "";
            modified1.Text = textBox1.Modified ? "Modified" : "";
            cut10.Enabled = copy10.Enabled = textBox1.SelectionLength > 0;
            paste10.Enabled = Clipboard.GetDataObject().GetDataPresent(typeof(string));
            save1.Enabled = save10.Enabled = textBox1.Modified;
        }

        private void toolBar1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolBar1.Checked = !toolBar1.Checked;
        }

        private void statusBar1_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBar1.Checked = !statusBar1.Checked;
        }

        private void new1_MouseEnter(object sender, EventArgs e)
        {
            hint1.Text = (sender as ToolStripMenuItem).ToolTipText;
        }

        private void new1_MouseLeave(object sender, EventArgs e)
        {
            hint1.Text = "";
        }

        private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
        {
            hint1.Text = "Ready";
        }

        private void SetEnabled(bool value)
        {
            bold1.Enabled = bold10.Enabled =
                italic1.Enabled = italic10.Enabled =
                    underline1.Enabled = underline10.Enabled =
                        font1.Enabled = value;
        }

        private void textBox1_SelectionChanged(object sender, EventArgs e)
        {
            
            int x = textBox1.SelectionStart,
                y = textBox1.GetLineFromCharIndex(x),
                x0 = textBox1.GetFirstCharIndexFromLine(y);
            position1.Text = $"{y + 1} : {x - x0 + 1}";
            toolStripStatusLabel1.Text = textBox1.SelectionLength.ToString();
            Font f = textBox1.SelectionFont;

            SetEnabled(f != null);
            if (f != null)
            {
                bold1.Checked = bold10.Checked = f.Bold;
                italic1.Checked = italic10.Checked = f.Italic;
                underline1.Checked = underline10.Checked = f.Underline;
            }

            ToolStripMenuItem mi = leftJustify1;
            switch (textBox1.SelectionAlignment)
            {
                case HorizontalAlignment.Center:
                    mi = center1;
                    break;
                case HorizontalAlignment.Right:
                    mi = rightJustify1;
                    break;
            }

            if (mi == alignItem) return;
            alignItem.Checked = GetButton(alignItem).Checked = false;
            mi.CheckState = CheckState.Indeterminate;
            GetButton(mi).Checked = true;
            alignItem = mi;
            
            
        }

        private void paragraph1_Click(object sender, EventArgs e)
        {
            form2.checkBox1.Checked = textBox1.SelectionBullet;
            form2.comboBox1.SelectedIndex = (int) textBox1.SelectionAlignment;
            form2.numericUpDown1.Value = textBox1.SelectionIndent;
            form2.numericUpDown2.Value = textBox1.SelectionRightIndent;
            form2.numericUpDown3.Value = textBox1.BulletIndent;
            if (form2.ShowDialog() == DialogResult.OK)
                textBox1.SelectionIndent = (int) form2.numericUpDown1.Value;
            textBox1.SelectionRightIndent = (int) form2.numericUpDown2.Value;
            textBox1.BulletIndent = (int) form2.numericUpDown3.Value;
            textBox1.SelectionBullet = form2.checkBox1.Checked;
            textBox1.SelectionAlignment =
                (HorizontalAlignment) form2.comboBox1.SelectedIndex;
            textBox1_SelectionChanged(this, null);
        }

        private RichTextBoxStreamType GetFileType(string path)
        {
            string s = Path.GetExtension(path).ToUpper();
            return s == ".RTF" ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = textBox1.TextLength.ToString();
        }
    }
}
// TODO 23.3