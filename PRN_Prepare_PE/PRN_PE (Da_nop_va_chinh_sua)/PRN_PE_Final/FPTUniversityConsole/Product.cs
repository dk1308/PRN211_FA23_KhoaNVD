using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTUniversityConsole
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitCost {  get; set; }

        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Quantity: {Quantity} - Price: {UnitCost*Quantity:N2}";
        }
    }
}
