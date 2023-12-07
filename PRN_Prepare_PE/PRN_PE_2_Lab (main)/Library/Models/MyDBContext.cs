using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Enrollment> Enrollments{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("MyDB"));
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>(
                    entity =>
                    {
                        entity.Property(s => s.StudentName)
                        .IsRequired()
                        .HasMaxLength(50);
                        entity.Property(s => s.Address)
                        .HasMaxLength(50);
                    }
                );
            modelBuilder.Entity<Course>(
                    entity =>
                    {
                        entity.Property(c => c.CourseName)
                        .IsRequired()
                        .HasMaxLength(50);
                    }
                );
            modelBuilder.Entity<Course>().HasData(
                    new Course { CourseId=1, CourseName= "Java core", Status = true},
                    new Course { CourseId=2, CourseName= "C# core", Status = false},
                    new Course { CourseId=3, CourseName= "ASP.NET", Status = true}
                );
            modelBuilder.Entity<Enrollment>(
                    entity =>
                    {
                        entity.HasKey(e => new { e.StudentId, e.CourseId });

                        entity.HasOne(e => e.Student).WithMany(s => s.Enrollments)
                        .HasForeignKey(e => e.StudentId)
                        .OnDelete(DeleteBehavior.Cascade);

                        entity.HasOne(e => e.Course).WithMany(s => s.Enrollments)
                        .HasForeignKey(e => e.CourseId)
                        .OnDelete(DeleteBehavior.Cascade);
                    }
                );
        }
    }
}
