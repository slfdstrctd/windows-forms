using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lesson11
{
    public partial class Form1 : Form
    {
        private XmlSerializer xmls = new XmlSerializer(typeof(List<Student>));
        public Form1()
        {
            InitializeComponent();
            this.bindingSource1.DataSource = new List<Student>();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
               return;

            string err = "";
            string s = e.FormattedValue.ToString();
            switch (e.ColumnIndex)
            {
                case 0:
                case 4:
                case 5:
                    int i;
                    if (!int.TryParse(s, out i))
                    {
                        err = "Строку нельзя преобразовать в число";
                        break;
                    }
                    if (i < 0)
                    {
                        err = "Отрицательные числа не допускаются";
                        break;
                    }
                    break;
                case 1:
                    if (s == "")
                    {
                        err = "Поле \"Фамилия\" должно быть непустым";
                        break;
                    }
                    break;
                case 2:
                    string upper = s.ToUpper();
                    if (upper != "М" && upper != "Ж")
                    {
                        err = "Допускаются значения \"М\" или \"Ж\"";
                        break;
                    }
                    break;
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
            this.menuStrip1.Enabled = !this.dataGridView1.IsCurrentCellDirty;
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
            
        }



        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) => this.bindingNavigatorDeleteItem.Enabled = !this.dataGridView1.Rows[e.RowIndex].IsNewRow;
    
    }
}
