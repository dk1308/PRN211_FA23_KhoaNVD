using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_trial
{
    internal class boxing
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;

            i = 456;
            Console.WriteLine(i);
            Console.WriteLine(o);
            Console.ReadLine();
        }
    }
}
