using _06.Slot6_DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Slot6_DesignPatterns
{
    interface IShape
    {
        public void aboutShape();
    }

    class Rectangle : IShape
    {
        public void aboutShape()
        {
            Console.WriteLine("This is rectangle!");
        }
    }

    class Triangle : IShape
    {
        public void aboutShape()
        {
            Console.WriteLine("This is triangle!");
        }
    }

    abstract class ShapeFactory
    {
        public abstract IShape printShape();
    }

    class RectangleFactory : ShapeFactory
    {
        public override IShape printShape() => new Rectangle();
    }

    class TriangleFactory : ShapeFactory
    {
        public override IShape printShape() => new Triangle();
    }

}

class Program
{
    //Main method
    static void Main(string[] args)
    {
        List<ShapeFactory> shapes = new List<ShapeFactory>()
         {
            new RectangleFactory(),
            new TriangleFactory()
         };

        foreach (ShapeFactory shape in shapes)
        {
            shape.printShape().aboutShape();
        }
    }
}