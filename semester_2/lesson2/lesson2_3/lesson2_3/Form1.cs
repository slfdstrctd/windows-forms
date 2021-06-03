using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lesson2_3
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = (DataSet) dataGridView1.DataSource;
            var xmldoc = new XmlDocument();
            xmldoc.InnerXml = ds.GetXml();
            // xmldoc.Save("tabl.xml");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.WriteXml(sfd.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}