using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace lesson11
{
    public partial class Form1 : Form
    {
        private XmlSerializer xmls = new XmlSerializer(typeof(List<Student>));
        private string surnameToFind = "";
        public Form1()
        {
            InitializeComponent();
            bindingSource1.DataSource = new List<Student>();
            bindingSource2.DataMember = "Marks";
            bindingSource2.DataSource = bindingSource1;
            label1.DataBindings.Add("Text", bindingSource1, "Surname");
            SetIntData(1, 6, dataGridView1.Columns["course1"]);
            SetIntData(1, 20, dataGridView1.Columns["group1"]);
            SetIntData(5, 2, dataGridView2.Columns["level1"]);

            id2.Tag = 0;
            surname2.Tag = 1;
            course2.Tag = 2;
            avrLevel2.Tag = 3;

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
               return;

            string err = "";
            string s = e.FormattedValue.ToString();
            switch (e.ColumnIndex)
            {
                //case 0:
                //case 4:
                //case 5:
                //    int i;
                //    if (!int.TryParse(s, out i))
                //    {
                //        err = "Строку нельзя преобразовать в число";
                //        break;
                //    }
                //    if (i < 0)
                //    {
                //        err = "Отрицательные числа не допускаются";
                //        break;
                //    }
                //    break;
                case 1:
                    if (s == "")
                    {
                        err = "Поле \"Фамилия\" должно быть непустым";
                        break;
                    }
                    break;
                //case 2:
                //    string upper = s.ToUpper();
                //    if (upper != "М" && upper != "Ж")
                //    {
                //        err = "Допускаются значения \"М\" или \"Ж\"";
                //        break;
                //    }
                //    break;
                case 3:
                    if (!(s == ""))
                    {
                        DateTime d;
                        if (!DateTime.TryParse(s, out d))
                        {
                            err = "Строку нельзя преобразовать в дату";
                            break;
                        }
                        int age = DateTime.Today.Year - d.Year;
                        if (age < 15 || age > 35)
                            err = "Текущий возраст студента должен находиться в диапазоне 15-35 лет";
                        break;
                    }
                    break;
            }
            e.Cancel = err != "";
            this.dataGridView1.Rows[e.RowIndex].ErrorText = err;
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].IsNewRow)
                return;
            string err = "";
            if (this.dataGridView1[1, e.RowIndex].Value == null)
                err = "Поле \"Фамилия\" должно быть непустым";
            e.Cancel = err != "";
            this.dataGridView1.Rows[e.RowIndex].ErrorText = err;

            //foreach (DataGridViewCell c in dataGridView1.Rows[e.RowIndex].Cells)
            //{
            //    if (c.ErrorText != "")
            //    {
            //        e.Cancel = true;
            //        return;
            //    }
            //}
        }

        private void SaveData(string name)
        {
            if (name == "" || this.dataGridView1.RowCount == 1)
                return;
            if (this.dataGridView1.CurrentRow.IsNewRow)
               this.dataGridView1.CurrentCell = this.dataGridView1[0, this.dataGridView1.RowCount - 2];
            StreamWriter streamWriter = new StreamWriter(name, false, Encoding.Default);
            this.xmls.Serialize((TextWriter)streamWriter, this.bindingSource1.DataSource);
            streamWriter.Close();
        }

        private void file1_DropDownOpening(object sender, EventArgs e) => this.saveAs1.Enabled = this.dataGridView1.RowCount > 1;

        private void new1_Click(object sender, EventArgs e)
        {
            this.SaveData(this.saveFileDialog1.FileName);
            this.bindingSource1.DataSource = new List<Student>();
            this.dataGridView1.CurrentCell = dataGridView1[0, 0];
            this.saveFileDialog1.FileName = "";
            this.Text = "Students";
        }

        private void open1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveData(saveFileDialog1.FileName);
                string s = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(s, Encoding.Default);
                bindingSource1.SuspendBinding();
                bindingSource1.DataSource = xmls.Deserialize((TextReader)sr);
                bindingSource1.ResumeBinding();
                sr.Close();
                saveFileDialog1.FileName = s;
                Text = "Students - " + Path.GetFileNameWithoutExtension(s);
            }
        }

        private void saveAs1_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                SaveData(s);
                Text = "Students - " + Path.GetFileNameWithoutExtension(s);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => SaveData(saveFileDialog1.FileName);

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            find1.Enabled = menuStrip1.Enabled = !this.dataGridView1.IsCurrentCellDirty;
            int row = this.dataGridView1.CurrentRow.Index;
            if (!dataGridView1.IsCurrentCellDirty && (int)dataGridView1["Id1", row].Value == 0)
            {
                int maxId = 0;
                for (int i = 0; i < row; ++i)
                {
                    int v = (int)this.dataGridView1["Id1", i].Value;
                    if (maxId < v)
                        maxId = v;
                }
                this.dataGridView1["Id1", row].Value = (maxId + 1);
            }

            if (!tabControl1.TabPages.Contains(tabPage2) && !dataGridView1.IsCurrentCellDirty)
                tabControl1.TabPages.Add(tabPage2);
            
        }



        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            find1.Enabled = bindingNavigatorDeleteItem.Enabled = !dataGridView1.Rows[e.RowIndex].IsNewRow;
            if (bindingNavigatorDeleteItem.Enabled && !tabControl1.TabPages.Contains(tabPage2))
                tabControl1.TabPages.Add(tabPage2);
            else if (!bindingNavigatorDeleteItem.Enabled && tabControl1.TabPages.Contains(tabPage2))
                tabControl1.TabPages.Remove(tabPage2);
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = dataGridView1;
        }

        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            menuStrip1.Enabled = !dataGridView2.IsCurrentCellDirty;
        }

        private void SetIntData(int a1, int a2, DataGridViewColumn c)
        {
            List<IntData> a = new List<IntData>();
            if (a1 < a2)
            {
                for (int i = a1; i <= a2; i++)
                    a.Add(new IntData(i));
            }
            else
            {
                for (int i = a1; i >= a2; i--)
                    a.Add(new IntData(i));
            }
            a.Add(new IntData(0));
            DataGridViewComboBoxColumn cbc = c as DataGridViewComboBoxColumn;
            cbc.DisplayMember = "StrValue";
            cbc.ValueMember = "IntValue";
            cbc.DataSource = a;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].IsNewRow || e.ColumnIndex != dataGridView1.Columns["avrLevel1"].Index)
                return;
            e.FormattingApplied = true;
            double a = (bindingSource1[e.RowIndex] as Student).AvrLevel;
            e.Value = a == 0.0 ? (object)"" : (object)a.ToString("f2");
        }

        private int CompareById(Student a, Student b) => a.Id - b.Id;

        private int CompareBySurname(Student a, Student b) => a.Surname.CompareTo(b.Surname);

        private int CompareByCourse(Student a, Student b)
        {
            int res = a.Course - b.Course;
            if (res == 0)
                res = a.Group - b.Group;
            if (res == 0)
                res = a.Surname.CompareTo(b.Surname);
            return res;
        }

        private int CompareByAvrLevel(Student a, Student b)
        {
            int res = Math.Sign(b.AvrLevel - a.AvrLevel);
            if (res == 0)
                res = a.Surname.CompareTo(b.Surname);
            return res;
        }

        private void id2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 1)
                return;
            this.dataGridView1.CurrentCell = this.dataGridView1[0, 0];
            Comparison<Student> comp = CompareById;
            switch ((int)(sender as ToolStripMenuItem).Tag)
            {
                case 1:
                    comp = CompareBySurname;
                    break;
                case 2:
                    comp = CompareByCourse;
                    break;
                case 3:
                    comp = CompareByAvrLevel;
                    break;
            }
            (bindingSource1.DataSource as List<Student>).Sort(comp);
            bindingSource1.ResetBindings(false);
        }

        private void find1_Click(object sender, EventArgs e)
        {
            surnameToFind = Interaction.InputBox("Введите начальную часть фамилии для поиска:", "Поиск по фамилии", this.surnameToFind).Trim();
            if (this.surnameToFind == "")
                return;
            int ind = (bindingSource1.DataSource as List<Student>).FindIndex(dataGridView1.CurrentRow.Index,
                delegate (Student a)
                {
                    return a.Surname.StartsWith(surnameToFind, StringComparison.OrdinalIgnoreCase);
                });
               
            if (ind != -1)
            {
                dataGridView1.CurrentCell = dataGridView1[1, ind];
            }
            else
            {
                MessageBox.Show("Фамилия не найдена", "Поиск по фамилии");
            }
        }
    }
}
