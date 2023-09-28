using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Collection_Generic
{
    internal class MyGeneric_2 
    {
        public void display<T, U>(T msg, U value)
        {
            Console.WriteLine($"{msg}:{value}");
        }
    }
}
