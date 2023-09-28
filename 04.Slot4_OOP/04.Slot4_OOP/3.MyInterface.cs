using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal interface MyInterface
    {
        String myProperty {  get; set; }
        String myMethod1();
        void myMethod2()
        {
            Console.WriteLine("ha");
        }
    }
}
