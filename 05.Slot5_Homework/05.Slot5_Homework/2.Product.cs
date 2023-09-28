using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Slot5_Homework
{
    internal class Product
    {
        public String Name { get; set; }
        public double Cost {  get; set; }
        public String Quantity {  get; set; }

        public override string? ToString() => $"Name: {Name} - Cost: {Cost} - Quantity: {Quantity}";
    }
}
