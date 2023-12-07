﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyServiceOptions
{
    public string Data1 { get; set; }
    public int Data2 { get; set; }
}
class MyService
{
    public string Data1 { get; set; }
    public int Data2 { get; set; }

    public MyService(IOptions<MyServiceOptions> options)
    {
        var data = options.Value;
        this.Data1 = data.Data1;
        this.Data2 = data.Data2;
    }

    public void PrintData()
    {
        Console.WriteLine($"{Data1}/{Data2}");
    }
}

public class IOptionsConfigure
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<MyService>();
        services.Configure<MyServiceOptions>(
            (options) =>
            {
                options.Data1 = "Hello world!";
                options.Data2 = 2023;   
            }
            );

        var provider = services.BuildServiceProvider();
        var s = provider.GetService<MyService>();

        s.PrintData();
    }
}
