using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld
{
    internal class string_interpolation
    {
        static void Main(string[] args)
        {
            double salary = 200.23412123;
            String name = "Khoa";
            String str1 = String.Format("Name{0,6}, Salary{1,7:N2}", name, salary);
            Console.WriteLine(str1);
            String str2 =   $"Name{name,6}, Salary{salary,7:N3}";
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
