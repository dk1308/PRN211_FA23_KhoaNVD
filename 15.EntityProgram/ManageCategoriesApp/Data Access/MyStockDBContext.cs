using ManageCategoriesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCategoriesApp.Data_Access
{
    public class MyStock: DbContext
    {
        public MyStock() { }
        
        // These properties map to tables in the database
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStockDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* using Fluent API instead of attributes
              to limit the length of a Category Name to under 40 */
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            // Insert data to Categories table
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Beverages"},
                    new Category { CategoryId = 2, CategoryName = "Condiments"},
                    new Category { CategoryId = 3, CategoryName = "Confections"}
                );
        }
    }
}
