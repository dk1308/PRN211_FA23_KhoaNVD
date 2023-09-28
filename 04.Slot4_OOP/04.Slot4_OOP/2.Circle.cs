using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class Circle:Shape
    {
        public int Radius { get; set; }

        public override void Display()
        {
            Console.WriteLine("Display Circle");
        }
    }
}
