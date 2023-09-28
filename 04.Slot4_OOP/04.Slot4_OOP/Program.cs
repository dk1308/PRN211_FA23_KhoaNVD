using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ****** List object
            /*List<Director> directors = new List<Director>()
            {
                new Director(1, "Khoa", "khoanvdde170341@fpt.edu.vn", 850000D),
                new Director(2, "Hoang", "hoang@fpt.edu.vn", 600D),
                new Director(3, "Tai", "tai@fpt.edu.vn", 840000D),
                new Director(3, "Hung", "hung@fpt.edu.vn", 830000D)
            };

            foreach (Director director in directors)
            {
                Console.WriteLine($"Director: {director}");
            }*/
            


            //****** Inheritance -> extends class
            /*Shape shape = new Circle();
            shape.Draw();
            shape.Print();
            shape.Display();
            shape = new Square();
            shape.Draw();
            shape.Print();
            shape.Display();
            Square shape2 = new Square();
            shape2.Print();*/



            //****** Inheritance -> implements interfacce
            MyInterface myClass = new MyClass();
            myClass.myMethod1();
            myClass.myMethod2();
        }
    }
}
