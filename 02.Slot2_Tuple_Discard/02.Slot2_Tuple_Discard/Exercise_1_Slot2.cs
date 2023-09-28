using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Tuple_Discard
{
    internal class Exercise_1_Slot2
    {   static void Main(string[] args)
        {
            Console.WriteLine("input side1:");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine("input side2:");
            float side2 = float.Parse(Console.ReadLine());

            
            (float perimeter, float area, float minSide) rec = exe(side1, side2);
            

            Console.WriteLine($"Perimeter: {rec.perimeter}");
            Console.WriteLine($"Area: {rec.area}");
            Console.WriteLine($"Min side: {rec.minSide}");

            (float perimeter, float area, float minSide) exe(float side1, float side2){
                return ((side1 + side2) * 2, side1 * side2, Math.Min(side1, side2));
            }    
        }



         
    }
}
