using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal abstract class Shape
    {
        public double Height {  get; set; }
        public double Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Draw shape");
        }

        public new void Print()
        {
            Console.WriteLine("Print shape");
        }

        public abstract void Display();


    }
}
