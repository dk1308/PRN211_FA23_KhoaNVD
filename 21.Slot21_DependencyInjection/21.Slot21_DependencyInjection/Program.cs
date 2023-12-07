
using Microsoft.Extensions.DependencyInjection;

class ClassA
{
    IClassB classB;
    public ClassA(IClassB classB)
    {
        this.classB = classB;
    }

    public void ActionA()
    {
        Console.WriteLine("Action in A");
        classB.ActionB();
    }
}
interface IClassB
{
    public void ActionB();
}

interface IClassC
{
    public void ActionC();
}
class ClassB : IClassB
{
    IClassC classC;
    public ClassB(IClassC classC)
    {
        this.classC = classC;
    }
    public void ActionB()
    {
        Console.WriteLine("Action in B");
        classC.ActionC();
    }
}

class ClassC : IClassC
{
    public void ActionC() => Console.WriteLine("Action in C");
}

class ClassB1 : IClassB
{
    IClassC classC;
    public ClassB1(IClassC classC)
    {
        this.classC = classC;
    }
    public void ActionB()
    {
        Console.WriteLine("Action in B1");
        classC.ActionC();
    }
}

class ClassB2 : IClassB
{
    IClassC classC;
    string message;
    public ClassB2(IClassC classC, string message)
    {
        this.classC = classC;
        this.message = message;
    }
    public void ActionB()
    {
        Console.WriteLine("Action in B1");
        Console.WriteLine(message);
        classC.ActionC();
    }
}

class ClassC1 : IClassC
{
    public void ActionC() => Console.WriteLine("Action in C1");
}

class Program
{
    static ClassB2 CreateB2(IServiceProvider provider)
    {
        ClassB2 b2 = new ClassB2(
            provider.GetService<IClassC>(),
            "Message in B2"
            );
        return b2;
    }
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<ClassA, ClassA>();
        /*services.AddSingleton<IClassB, ClassB2>(
            (provid) =>
            {
                ClassB2 b2 = new ClassB2(
                    provid.GetService<IClassC>(),
                    "Message in B2"
                    );
                return b2; 
            }
            ); // Use delegate to inject dependency which is not object*/

        services.AddSingleton<IClassB>(CreateB2); // use factory to inject ...
        services.AddSingleton<IClassC, ClassC1>();

        var provider = services.BuildServiceProvider();

        ClassA classA = provider.GetService<ClassA>();

        classA.ActionA();
    }
}