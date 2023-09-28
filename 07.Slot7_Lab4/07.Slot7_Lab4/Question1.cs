using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Slot7_Lab4
{
    internal class MathOperations
    {
        public void add(float x, float y) => Console.WriteLine($"x+y={x+y}");
        public void subtract(float x, float y) => Console.WriteLine($"x-y={x-y}");
        public void multiply(float x, float y) => Console.WriteLine($"x*y={x*y}");
        public void divide(float x, float y) => Console.WriteLine($"x/y={x/y}");
    }

    class MyClass
    {
        public delegate void myDele(float a, float b);

        static void Main(string[] args)
        {
            MathOperations m = new MathOperations();
            myDele d = m.add;
            d += m.subtract;
            d += m.multiply;
            d += m.divide;

            d(5, 20);
        }
    }
}
