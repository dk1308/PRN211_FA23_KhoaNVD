using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

class Program
{
    // Get connection string from appsettings.json
    static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        var strConnection = config["ConnectionStrings:MyStore"];
        return strConnection;
    }// end GetConnectionString

    static void ViewProducts()
    {
        DbProviderFactory factory = SqlClientFactory.Instance;
        //Get the connection object
        using DbConnection connection = factory.CreateConnection();

        if (connection == null)
        {
            Console.WriteLine($"Unable to create the connection object.");
            return;
        }
        connection.ConnectionString = GetConnectionString();
        connection.Open();

        //Make command object
        DbCommand command = factory.CreateCommand();
        if(connection == null)
        {
            Console.WriteLine($"Unable to create the command object.");
            return;
        }

        command.Connection = connection;
        command.CommandText = "Select * from products";

        // Print out data with daata reader
        using DbDataReader dataReader = command.ExecuteReader();
        Console.WriteLine("***** Product List *****");
        while (dataReader.Read()) {
            Console.WriteLine($"ProductID: {dataReader["ProductID"]}\n ProductName: {dataReader["ProductName"]}");
        }
    } // end ViewProduucts

    static void Main(string[] args)
    {
        ViewProducts();
        Console.ReadLine();
    }
}