using FPTUniversityConsole;

public class Program
{
    static void Main(string[] args)
    {
        // Question 1.3.1
        MyGenericClass<int> myGenericClass = new MyGenericClass<int>();
        myGenericClass.Value = 100;
        Console.WriteLine($"Value of intObj: {myGenericClass.Value}");

        // Question 1.3.2
        MyGenericClass<string> myGenericClass2 = new MyGenericClass<string>();
        myGenericClass2.Value = "Hello";
        Console.WriteLine($"Value of intObj: {myGenericClass2.Value}");

        // Question 1.3.3
        MyGenericClass<Product> myGenericClass3 = new MyGenericClass<Product>();
        myGenericClass3.Value = new Product
        {
            Id = 1,
            Name = "Dell",
            Quantity = 100,
            UnitCost = 12.0012
        };
        Console.WriteLine($"Value of intObj: {myGenericClass3.Value}");
    }
}