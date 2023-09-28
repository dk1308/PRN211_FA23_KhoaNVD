using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_trial
{
    internal class var_initialize
    {
        static void Main(string[] args)
        {
            dynamic myInt = 1;
            Console.WriteLine($"myInt: {myInt}, {myInt.GetType().Name}");
            myInt = 7;
            Console.WriteLine($"myInt: {myInt}, {myInt.GetType().Name}");
            var myBoolean = true;
            Console.WriteLine($"myBoolean: {myBoolean.GetType().Name}");
            var myString = "Hello World";
            Console.WriteLine($"myString: {myString.GetType().Name}");
            var myDouble = 5.5;
            Console.WriteLine($"myDouble: {myDouble.GetType().Name}");
        }
    }
}
