using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    
    public class Student{
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Counted { get; set; }		
    }
    public partial class Form1 : Form
    {
        IList<Student> studentList = new List<Student>() { 
            new Student() { Surname = "КИМ", Name = "ЭРИК", Counted = true } ,
            new Student() { Surname = "ПОНОМАРЕНКО", Name = "АРТЕМ", Counted = true } ,
            new Student() { Surname = "ХАРЛАМОВ", Name = "ВЛАДИСЛАВ", Counted = false } ,
            new Student() { Surname = "КРАШЕНИННИКОВ", Name = "ЕГОР", Counted = true } , 
            new Student() { Surname = "МАЛЬКОВ", Name = "РОМАН", Counted = true } , 
        };
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            label3.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToUpper();
            var student = studentList
                .Select(st => st)
                .Where(st => st.Name.Contains(s) || st.Surname.Contains(s))
                .OrderByDescending(x => x.Surname)
                .Take(1)
                .ToList();
            
            
            if (student.Count() != 0)
            {
                foreach (var ss in student)
                {
                    label3.Text = ss.Name + " " + ss.Surname + (!ss.Counted ? " не " : " ") + "получит зачёт\n";
                }
            }
            else label3.Text = s + " не получит зачёт";
            label3.Visible = true;
        }
    }
}