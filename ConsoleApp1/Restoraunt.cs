using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Restoraunt
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Humane> Owners;
        public Kitchen Kitchen;
        public List<Hall> Halls;
        public Bar Bar;
    }
}
