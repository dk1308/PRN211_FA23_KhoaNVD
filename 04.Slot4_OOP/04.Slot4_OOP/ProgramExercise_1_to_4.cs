using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class ProgramExercise_1_to_4
    {
        static void Main(string[] args)
        {
            // Exercise 1-2
            /*Product p1 = new Product();
            Product p2 = new Product();
            Console.WriteLine("Input product 1 info");
            p1.input();
            Console.WriteLine("Input product 2 info");
            p2.input();

            Console.WriteLine("Product 1 info");
            p1.display();
            Console.WriteLine("Product 2 info");
            p2.display();*/


            // Exercise 3-4
            Product p1 = new Product("Iphone 14", 30000F, 2F);
            Product p2 = new Product("Iphone 13 Pro", 25000F);
            Console.WriteLine("Product 1 info");
            p1.display();
            Console.WriteLine("Product 2 info");
            p2.display(); 
        }
    }
}
