using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class MyClass : MyInterface
    {
        public string myProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string myMethod1()
        {
            Console.WriteLine("1");
            return "";
        }

        public new void myMethod2()
        {
            Console.WriteLine("2");
        }
    }
}
