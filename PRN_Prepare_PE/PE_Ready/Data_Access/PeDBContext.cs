
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class Users
    {
        public Users() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<News> News { get; set; } = new List<News>();
    }

    public class Categories
    {
        public Categories() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatetoryID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<News> News { get; set; } = new List<News>();
    }

    public class News
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CatetoryID { get; set; }
        public string Titles { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdate { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public virtual Users? Users { get; set; }
        public virtual Categories? Categories { get; set; }

    }
    public class PeDB : DbContext
    {
        public PeDB() { }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PeDB"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {

                entity.Property(e => e.UserName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);
               
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasOne(d => d.Users).WithMany(p => p.News)
                    .HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(d => d.Categories).WithMany(p => p.News)
                   .HasForeignKey(d => d.CatetoryID).OnDelete(DeleteBehavior.Cascade);
            });

            //------------------------------------Insert Data----------------------------------------
            modelBuilder.Entity<Users>().HasData(
                new Users { UserId=1, UserName="pika", FullName="pikachu", Password="123", Status=true}
                );
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CatetoryID=1, Name="Pokemon", Status=true },
                new Categories { CatetoryID = 2, Name = "Doraemon", Status = true }
                );
        }



    }
}
