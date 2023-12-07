using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomibileLibrary.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider DataProvider { get; set; } = null;
        public SqlConnection connection = null;
        //------------------------------------------------------
        public BaseDAL() {
            var connectionString = GetConnectionString();
            DataProvider = new StockDataProvider(connectionString);
        }
        //------------------------------------------------------
        public string GetConnectionString()
        {
            string connectionString = null;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionStrings:MyStockDB"];
            return connectionString;
        }
        //------------------------------------------------------
        public void CloseConnection() => DataProvider.CloseConnection(connection);
    } // end class
}// end namespace
