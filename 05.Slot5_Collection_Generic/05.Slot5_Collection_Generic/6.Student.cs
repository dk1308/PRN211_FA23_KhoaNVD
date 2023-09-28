using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Collection_Generic
{
    internal class Student
    {
        public String Name { get; set; }
        public int Age {  get; set; }
        public double Mark {  get; set; }

        public Student(String name, int age, double mark) { 
            Name = name;
            Age = age;
            Mark = mark;
        }
        public override string ToString() => $"{Name}: {Age} - {Mark}";
    }
}
