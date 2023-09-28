using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class IS_AS_Operator
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Shape shapeObject;
            if(square is Shape)
            {
                shapeObject = square as Shape;
                shapeObject.Draw();
            }
            else
            {
                Console.WriteLine("Interface method not implemented!");
            }
        }
    }
}
