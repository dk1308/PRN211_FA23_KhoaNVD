
using _05.Slot5_Homework;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // I. Question1
        /*CalculatorInt calInt = new CalculatorInt();
        Console.WriteLine($"1 + 2 = {calInt.Add(1, 2)}");*/

        // II. Question2
        /*List<Product> products = new List<Product>();
        products.Add(new Product() { Name = "Iphone 15", Cost = 1000D, Quantity = "Normal" });
        products.Add(new Product() { Name = "Ipad", Cost = 2000D, Quantity = "Good" });
        products.Add(new Product() { Name = "Mac M1", Cost = 3000D, Quantity = "Bad" });
        products.Add(new Product() { Name = "Iphone 13 Pro Max", Cost = 700D, Quantity = "Good" });
        products.Add(new Product() { Name = "Iphone 11", Cost = 450D, Quantity = "Excellent" });
        Console.WriteLine($"Number of products: {products.Count}");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }*/

        // III. Question3
        /*Hashtable myHashTable = new Hashtable();
        myHashTable.Add(1, "Monday");
        myHashTable.Add(2, "Tuesday");
        myHashTable.Add(3, "Wednesday");
        myHashTable.Add(4, "Thursday");
        myHashTable.Add(5, "Friday");
        myHashTable.Add(6, "Saturday");
        myHashTable.Add(7, "Sunday");

        // find friday
        Boolean isFound = false;
        object index = null;
        foreach(DictionaryEntry day in myHashTable)
        {
            if (day.Value.Equals("Friday"))
            {
                isFound = true;
                index = day.Key;
                break;
            }
        }
        if (isFound==true)
        {
            Console.WriteLine($"Friday found at key {index}");
        }
        else Console.WriteLine($"Not found Friday");

        // print all days
        foreach (DictionaryEntry day in myHashTable) 
            Console.WriteLine($"{day.Key}: {day.Value}");*/

        // IV. Question 4
        SwapTwoValue swapClass = new SwapTwoValue();
        int a = 12;
        int b = 28;
        Console.WriteLine($"Before swap: a={a}, b={b}");
        swapClass.DoSwap( ref a, ref b );
        Console.WriteLine($"After swap: a={a}, b={b}");
    }
}
