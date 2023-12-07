using _02.Slot2_Test;

sealed class Program
{
    static void Main(string[] args)
    {
        (string a, int b) info = new Student().getInfo();
        Console.WriteLine($"student name: {info.a}, student age: {info.b}");
    }
}
