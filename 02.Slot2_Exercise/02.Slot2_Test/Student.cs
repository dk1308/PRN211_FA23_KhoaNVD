using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Test
{
    public class Student
    {
        public static string getName() => "Nhat Anh";
        public (string, int) getInfo() => ("Nhat Anh", 10);

        public delegate int calculateDelegate(int a, int b);
        public delegate void Print(string s);
        public static void print1(string s) => Console.WriteLine(s);
        public static void print2(string s) => Console.WriteLine(s);
        public static int add(int a, int b) => a + b;
        public static int sub(int a, int b) => a - b;

        static void Main(string[] args)
        {
            Print p = print1;
            p += print2;
            p("haha");
            List<int> lists = new List<int>{1,2, 3};    
        }

    }
}
