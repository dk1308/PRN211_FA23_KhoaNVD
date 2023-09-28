// See https://aka.ms/new-console-template for more information

using _05.Slot5_Collection_Generic;
using System.Collections.Generic;
using System.Numerics;

namespace _Slot5
{
    class Program
    {
        static void Main(string[] args)
        {
            // I.Test collection
            /*MyCollection mc = new MyCollection();
            mc.AddInt(1);
            mc.AddInt(5);
            mc.AddInt(3);
            for (int i = 0; i < mc.Count(); i++)
                Console.WriteLine($"value: {mc.GetInt(i)}");*/


            // II.Test generic 1 
            /*MyGeneric<String> g1 = new MyGeneric<String>() { Value = "Khoa"};
            Console.WriteLine(g1);
            MyGeneric<int> g2 = new MyGeneric<int>() { Value = 123 };
            Console.WriteLine(g2);
            MyGeneric<dynamic> g3 = new MyGeneric<dynamic>() { Value = new { Id = 1, name = "hoanggay" }};
            Console.WriteLine(g3);*/

            // III.Test generic 2 
            /*MyGeneric_2 myGeneric = new MyGeneric_2();
            myGeneric.display<string, double>("number", 12D);
            myGeneric.display<int, char>(85, 'c');
            myGeneric.display<string, object>("me", new {name ="khoa", age=20});*/

            // IV.Test generic constraint

            // V.Test generic interface
            /*myClass1 mc1 = new myClass1();
            dynamic result = mc1.Add(4, 3);
            Console.WriteLine(result);
            myClass2 mc2 = new myClass2();
            result = mc2.Add(10.5F, 2F);
            Console.WriteLine(result);
            Console.ReadLine();*/

            // VI.Test list 
            /*List<Student> students = new List<Student>();
            students.Add(new Student("Khoa", 20,10D)); 
            students.Add(new Student("Hoang", 0,5D)); 
            students.Add(new Student("Tai", 0,5D)); 
            students.Add(new Student("Hung", 0,5D));

            Console.WriteLine("Number of students: {0}", students.Count);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }*/

            // VII.Test sortedset
            /*SortedSet<int> mySet = new SortedSet<int>() {15,-5,1,6,20};
            mySet.Add(-5);
            mySet.Add(0);
            mySet.Add(19);
            mySet.Add(-2);
            mySet.Add(31);
            mySet.Add(101);
            Console.WriteLine("Number of elements: {0}", mySet.Count);
            foreach (int element in mySet)
            {
                Console.Write($"{element,5}");
            }*/

            // VIII.Test dictionary
            Dictionary<String, String> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("Khoa", "DepTrai");
            myDictionary.Add("Hoang", "XauTrai");
            myDictionary.Add("Tai", "BinhThuong");
            myDictionary.Add("Hung", "XauVai");
            Console.WriteLine("Number of elements: {0}", myDictionary.Count);
            foreach ( KeyValuePair<String,String> element in myDictionary)
            {
                Console.Write($"{element.Key} ");
            }
        }
    }
}
