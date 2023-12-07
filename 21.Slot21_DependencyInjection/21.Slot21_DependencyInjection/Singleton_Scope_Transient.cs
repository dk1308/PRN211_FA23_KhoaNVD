using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Horn
{
    public void Beep()
    {
        Console.WriteLine("Beep..Beep..");
    }
}

public class Car
{
    Horn horn;
    public Car(Horn horn)
    {
        this.horn = horn;
    } 
}


class Programm
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddScoped<Horn>();

        var provider = services.BuildServiceProvider();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(provider.GetService<Horn>().GetHashCode());
        }

        using (var scope = provider.CreateScope()) 
        {
            var subProvider = scope.ServiceProvider;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(subProvider.GetService<Horn>().GetHashCode());
            }
        }
    }
}

