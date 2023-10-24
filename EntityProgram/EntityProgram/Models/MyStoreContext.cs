using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityProgram.Models;

public partial class MyStoreContext : DbContext
{
    public MyStoreContext()
    {
    }

    public MyStoreContext(DbContextOptions<MyStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-8EJE3NEE;Database=MyStore;User Id=sa;Password=123456;TrustServerCertificate=true;Trusted_Connection=SSPI;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BE1EF148A");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
            .IsRequired()
            .HasMaxLength(45)
            .UseCollation("Vietnamese_CI_AS");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED5C80F975");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("ProductID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(45)
                .UseCollation("Vietnamese_CI_AS");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__Catego__25869641");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
