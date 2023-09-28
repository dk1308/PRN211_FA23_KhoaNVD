using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Tuple_Discard
{
    internal class PatternMatching
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input n: ");
            int.TryParse(Console.ReadLine(), out int n);
            if(n is String)
            {
                Console.WriteLine($"{n} is String");
            } else Console.WriteLine($"{n} is not String");

            Console.WriteLine($"n= {n}");
            switch (n)
            {
                case int count when count>0: // = case int when n>0
                    for (int i=0; i < count; i++)
                    {
                        Console.Write("*");
                    }
                    break;
                default: Console.WriteLine("invalid input!");
                    break;
            }
        }
    }
}
