using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Transactions;

namespace FirstADOApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestDBConnection();
        }

        public static void TestDBConnection()
        {
            var config = Configuration();
            using var conn = new SqlConnection(config.GetConnectionString("HRDb"));
            conn.Open();

            GetListJobs(conn);
            CountJobs(conn);

            var trans = conn.BeginTransaction();
            InsertJob("Software Engineer", 12000, 24000, conn, trans);
        }

        public static IConfiguration Configuration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true);
            IConfiguration config = builder.Build();
            return config;
        }

        public static void GetListJobs(SqlConnection conn)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT job_id, job_title FROM JOBS";

            using var reader = cmd.ExecuteReader();
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Jobs: ID: {reader.GetInt32(0)} - Title: {reader.GetString(1)}");
                }
            }
            reader.Close();
        }

        public static void CountJobs(SqlConnection conn)
        {
            var countCmd = new SqlCommand("SELECT COUNT(*) FROM JOBS", conn);

            int c = (int)countCmd.ExecuteScalar();
            Console.WriteLine($"Total: {c} jobs");
        }

        public static void InsertJob(string jobTitle, double minSalary, double maxSalary, SqlConnection conn, SqlTransaction trans)
        {
            var cmd = new SqlCommand("INSERT INTO JOBS(job_title, min_salary, max_salary) VALUES (@jobTitle, @minSalary, @maxSalary)", conn, trans);
            cmd.Parameters.AddWithValue("jobTitle", jobTitle);
            cmd.Parameters.AddWithValue("minSalary", minSalary);
            cmd.Parameters.AddWithValue("maxSalary", maxSalary);
            cmd.ExecuteNonQuery();
            trans.Commit();
        }
    }

}