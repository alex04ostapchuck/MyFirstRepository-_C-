using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Сustomer:Humane
    {
        public int Number;
        public Happynnes Happynnes { get; set; }
        public First First { get; set; }
        public Second Second { get; set; }
        public Drink Drink { get; set; }
    }
}
