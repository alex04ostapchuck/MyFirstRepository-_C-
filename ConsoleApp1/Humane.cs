using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Humane
    {
        public int Id;
        public string Name;
        public int Age;
        public Gender Sex;
        public Humane()
        {
            Sex = (Gender)Data.Rand(0, 2);
            if(Sex == 0)
            {
                Name = Data.NameMale();
            }
            else
            {
                Name = Data.NameFemale();
            }
            Id = Data.Rand(1, 100000);
            Age = Data.Rand(18, 50);
        }
        
    }
}
