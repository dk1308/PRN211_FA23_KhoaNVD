using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Exercise
{
    internal class Exercise3
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            
            Console.WriteLine("input a:");
            if (double.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("input b:");
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("input c:");
                    if (double.TryParse(Console.ReadLine(), out c))
                    {
                        (double? x1, double? x2)  = ((double? x1, double? x2))calculate(a, b, c);
                        if (x1 == null) Console.WriteLine($"solution not exists!"); 
                        else if (x1 == x2) Console.WriteLine($"x={x1}");
                        else Console.WriteLine($"x1={x1}; x2={x2}");
                        return;
                    } 
                }
            }
            Console.WriteLine("invalid input!");
        }
            
        static (double? x1, double? x2)? calculate (double a, double b, double c) 
        {
            if (a == 0)
            {
                return (-c / b, -c / b);
            }
                double delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta >= 0)
            {
                return ((-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
            }

            return (null,null);

        }
    }
}
