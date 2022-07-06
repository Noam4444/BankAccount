using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Bank
    {
        static int Ids = 1;
        public int Id;
        public string Name;
        public int InAmt, OutAmt, Sum;
        public Bank(string Name)
        {
            this.Name = Name;
            Id = Ids++;
        }
    }
}
