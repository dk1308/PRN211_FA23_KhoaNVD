using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Slot6_DesignPatterns
{
    public abstract class Car
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }
        public int BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        public int OnRoadPrice {
            get { return onRoadPrice; }
            set { onRoadPrice = value; }
        } 

        public static int SetAdditionalPrice()
        {
            Random rand = new Random();
            int additionalPrice = rand.Next(200, 500);
            return additionalPrice;
        }

        public abstract Car clone();
    }

    public class Mustang : Car
    {
        public Mustang(String model)
        {
            (ModelName, BasePrice) = (model, 200);
        }
        public override Car clone()
        {
            return this.MemberwiseClone() as Mustang;
        }
    }

    public class BMW : Car
    {
        public BMW(String model)
        {
            (ModelName, BasePrice) = (model, 300);
        }
        public override Car clone()
        {
            return this.MemberwiseClone() as BMW;
        }
    }

    class ProgramPrototype
    {
        static void Main(string[] args)
        {
            // Original copy
            Car mustang = new Mustang("mustang");
            Car bmw = new BMW("bmw");

            // Before clone
            Console.WriteLine($"Car is: {mustang.ModelName}, baseprice is: {mustang.BasePrice}");
            Console.WriteLine($"Car is: {bmw.ModelName}, baseprice is: {bmw.BasePrice}");

            Car car;
            car = mustang.clone();
            // Working on cloned copy
            car.OnRoadPrice = car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {car.ModelName}, onroadprice is: {car.OnRoadPrice}");

            car = bmw.clone();
            // Working on cloned copy
            car.OnRoadPrice = car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {car.ModelName}, onroadprice is: {car.OnRoadPrice}");
        }
    }
}
