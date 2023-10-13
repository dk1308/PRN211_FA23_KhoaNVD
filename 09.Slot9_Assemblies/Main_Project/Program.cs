
using _09.Slot9_Assemblies_Class_Library;
using System.ComponentModel;

public class Program
{
    static void Main(string[] args)
    {
        float a = 10.23F;
        float b = 2F;
        float area = CalculateRectangle.CalculateArea(a, b);
        float perim = CalculateRectangle.CalculatePerimeter(a, b);
        Console.WriteLine($"Rectangle({a} , {b}) has area: {area}\n\t\t\tperimeter: {perim}");
    }
}
