class A
{
    protected static int x=3;
    public A()
    {
        x +=2;
    }
    static A()
    {
        x++;
    }
    public virtual void Print()
    {
        Console.WriteLine(x*x);
    }
}

class B : A
{
    public void Print()
    {
        Console.WriteLine(x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*A b = new B();
        b.Print();*/

        Console.Write(6 & 2);
    }
}