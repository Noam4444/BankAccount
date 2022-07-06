using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Move
    {
        static int Ids = 1;
        public int Id,Sum;
        public int InId, OutId;
        public string Name;
        public DateTime Date;
        public Move(string name, int sum, int inId, int outId, DateTime date)
        {
            Id = Ids++;
            Name = name;
            Sum = sum;
            InId = inId;
            OutId = outId;
            Date = date;
        }
    }
}
