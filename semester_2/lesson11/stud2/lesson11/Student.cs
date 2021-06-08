using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace lesson11
{
    public class Student
    {
        private int id;
        private string surname;
        private string gender = "М";
        private DateTime birthDate;
        private int course;
        private int group;
        private bool scholarship;
        private List<Mark> marks;

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        public string Surname
        {
            get => this.surname;
            set => this.surname = value;
        }

        public string Gender
        {
            get => this.gender;
            set => this.gender = value;
        }

        public DateTime BirthDate
        {
            get => this.birthDate;
            set => this.birthDate = value;
        }

        public int Course
        {
            get => this.course;
            set => this.course = value;
        }

        public int Group
        {
            get => this.group;
            set => this.group = value;
        }

        public bool Scholarship
        {
            get => this.scholarship;
            set => this.scholarship = value;
        }

        public List<Mark> Marks
        {
            get => this.marks;
            set => this.marks = value;
        }

        public double AvrLevel
        {
            get
            {
                if (this.Marks == null)
                    return 0;
                double sum = 0.0;
                int cnt = 0;
                foreach (Mark m in this.Marks)
                {
                    if (m.Level != 0)
                    {
                        sum += m.Level;
                        cnt++;
                    }
                }
                if (cnt > 0)
                    sum /= cnt;
                return sum;
            }
        }
    }
}
