using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace anotherspace;
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

    public void PrintData() => Console.WriteLine($"{Data1} / {Data2}");
}

public class ConfigureFromFile
{
    static void Main(string[] args)
    {
        IConfigurationRoot configurationRoot;

        // Config buider
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("config.json");

        // Initial configRoot
        configurationRoot = builder.Build();

        // Get section from configRoot (file config.json)
        var key1 = configurationRoot["MySection:Key1"];
        Console.WriteLine(key1);

        var services = new ServiceCollection();
        services.AddSingleton<MyService>();

        // configure service from configRoot (file config.json)
        services.Configure<MyServiceOptions>(configurationRoot.GetSection("MyServiceOptions"));

        var provider = services.BuildServiceProvider();
        var s = provider.GetService<MyService>();
        s.PrintData();
    }
}

