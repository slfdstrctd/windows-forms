using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            var dataSet1 = new DataSet();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            dataSet1.ReadXml("C:/Users/slfdstrctd/RiderProjects/lesson2_2/lesson2_2/tabl.xml");

            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "person";
            // dataGridView1.Size = new Size(300, 150);
        }
    }
}