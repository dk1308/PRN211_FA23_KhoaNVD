using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Slot11_Lab
{
    internal class Student
    {
        private string FullName { get; set; }
        private float MathMark { get; set; }
        private float PhysicalMark { get; set; }
        private float ChemistryMark { get; set; }

        private float Average { get; set; }
        public Student(string fullName, float mathMark, float physicalMark, float chemistryMark)
        {
            FullName = fullName;
            MathMark = mathMark;
            PhysicalMark = physicalMark;
            ChemistryMark = chemistryMark;
            Average = (MathMark+PhysicalMark+ChemistryMark)/3.0f;
        }
        override
            public string ToString() => $"{FullName}, {MathMark}-{PhysicalMark}-{ChemistryMark}, {Average}" ;
    }
}
