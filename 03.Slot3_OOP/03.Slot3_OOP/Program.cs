using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Slot3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerID = 1;
            Console.WriteLine(customer.ToString());
            customer.CustomerID = 2;
            customer.CustomerName = "Tai` nu nu";
            Console.WriteLine(customer.ToString());

            Console.ReadLine();
        }
    }
}
