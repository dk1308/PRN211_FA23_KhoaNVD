using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class Director:Employee
    {
        public string Email {  get; set; }
        public double Salary {  get; set; }

        public Director(int id, string name, string email, double salary):base(id, name)
        {
            Email = email;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"{ID} / {Name} / {Email} / {Salary}";
        }
    }
}
