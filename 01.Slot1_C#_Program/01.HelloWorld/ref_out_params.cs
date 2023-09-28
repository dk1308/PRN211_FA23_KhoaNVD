using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld
{
    internal class ref_out_params
    {
        static void Main(string[] args)
        {
            int s;
            SumArray( out s, 1, 2, 3, 4);
            Console.WriteLine(s);
            Console.ReadLine();
        }

        private static void SumArray( out int s, params int[] list)
        {
            s = 0;
            for (int i = 0; i < list.Length; i++)
            {
                s += list[i];
            }
        }

        
    }
}
