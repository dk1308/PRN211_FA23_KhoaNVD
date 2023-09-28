using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class Square:Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Draw Square");
        }

        public void Print()
        {
            Console.WriteLine("Print Square");
        }
        public override void Display()
        {
            Console.WriteLine("Display Square");
        }

        
    }
}
