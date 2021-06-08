using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    public class Mark
    {
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
