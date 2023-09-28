using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Slot6_DesignPatterns
{
    interface IClothes
    {
        public void createClothes();
    }

    class RedShirt : IClothes
    {
        public void createClothes() => Console.WriteLine("RedShirt");    
     }

    class RedPants : IClothes
    {
        public void createClothes() => Console.WriteLine("RedPants");
    }

 

    class BlueShirt : IClothes
    {
        public void createClothes() => Console.WriteLine("BlueShirt");
    }

    class BluePants : IClothes
    {
        public void createClothes() => Console.WriteLine("BluePants");
    }

    abstract class ClothesFactory
    {
        public abstract IClothes createRedClothes();
        public abstract IClothes createBlueClothes();
    }

    class ShirtFactory : ClothesFactory
    {
        public override IClothes createRedClothes() => new RedShirt();
        public override IClothes createBlueClothes() => new BlueShirt();
    }

    class PantsFactory : ClothesFactory
    {
        public override IClothes createRedClothes() => new RedPants();
        public override IClothes createBlueClothes() => new BluePants();
    }

    class ProgramAbstractFactory
    {
        static void Main(string[] args)
        {
            List<ClothesFactory> list = new List<ClothesFactory>() { 
                new ShirtFactory(), new PantsFactory()
            };
            foreach(ClothesFactory factory in list)
            {
                factory.createRedClothes().createClothes();
                factory.createBlueClothes().createClothes();
            }
        }
    }
}
