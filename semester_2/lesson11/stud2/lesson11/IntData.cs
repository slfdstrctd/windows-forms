using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    public class IntData
    {
        private int intValue;

        public int IntValue
        {
            get => this.intValue;
            set => this.intValue = value;
        }

        public string StrValue
        {
            get => this.intValue == 0 ? " " : this.intValue.ToString();
            set => int.TryParse(value, out this.intValue);
        }

        public IntData(int value) => this.intValue = value;
    }
}
