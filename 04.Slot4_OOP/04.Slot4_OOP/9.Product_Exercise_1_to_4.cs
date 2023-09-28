using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Slot4_OOP
{
    internal class Product
    {
        private String name;
        private double price;
        private double discount;

        public Product()
        {

        }

        public Product(String name, double price, double discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }

        public Product(String name, float price) {
            Name = name;
            Price = price;
            Discount = 0;
        }
        public String Name { 
            get { return this.name;  }
            set {  this.name = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }

        private double getImportTax()
        {
            return Price / 10;
        }

        public void display()
        {
            Console.WriteLine($"name: {Name} \n price: {Price} \n discount: {Discount}");
        }

        public void input()
        {
            Console.Write("Input name: ");
            Name = Console.ReadLine();
            Console.Write("Input price: ");
            double.TryParse(Console.ReadLine(), out this.price);
            Console.Write("Input discount: ");
            double.TryParse(Console.ReadLine(), out this.discount);
        }
    }
}
