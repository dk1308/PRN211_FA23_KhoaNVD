using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class Expression_Anonymous
    {
        static void Main(string[] args)
        {
            var obj = new { id = 1, name = "Khoa" };
            display(obj);
        }

        static void display(Object obj) => Console.WriteLine(obj.ToString());
    }
}
