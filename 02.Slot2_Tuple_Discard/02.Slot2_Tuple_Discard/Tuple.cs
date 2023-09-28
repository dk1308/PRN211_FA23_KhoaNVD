using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Slot2_Tuple
{
    internal class Tuple
    {   
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Input info student "+(i+1));
                if(i == 0)
                {
                    student1.StudentName = Console.ReadLine();
                    student1.StudentAge = int.Parse(Console.ReadLine());
                    student1.StudentSchool = Console.ReadLine();
                } else
                {
                    student2.StudentName = Console.ReadLine();
                    student2.StudentAge = int.Parse(Console.ReadLine());
                    student2.StudentSchool = Console.ReadLine();
                }
            }
            Console.WriteLine(name2Student(student1,student2));
        }

        static (String name1, String name2) name2Student(Student s1, Student s2)
        {
            return (s1.StudentName, s2.StudentName);
        }
    }

    public class Student 
    {
        private int Age;
        public String StudentName { get; set; }
        public int StudentAge { get { return Age; } set { this.Age = value; } }
        public String StudentSchool { get; set; }

        public void print()
        {
            Console.WriteLine(StudentName+" | "+StudentAge);
           
        }
    }
}
