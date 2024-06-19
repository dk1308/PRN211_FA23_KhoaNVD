using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Models;

public partial class SmdbContext : DbContext
{
    public SmdbContext()
    {
    }

    public SmdbContext(DbContextOptions<SmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Orderr> Orderrs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-8EJE3NEE;Database=SaleManagementDB;User Id=sa;Password=123456;TrustServerCertificate=true;Trusted_Connection=SSPI;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Member__0CF04B182126BBF9");

            entity.ToTable("Member");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PK__OrderDet__08D097A33EFA8264");

            entity.ToTable("OrderDetail");

            entity.HasOne(d => d.Orderr).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDeta__Order__2D27B809");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDeta__Produ__2E1BDC42");
        });

        modelBuilder.Entity<Orderr>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orderr__C3905BCF06029E0C");

            entity.ToTable("Orderr");

            entity.Property(e => e.OrderId).ValueGeneratedNever();
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.Orderrs)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Orderr__MemberId__2A4B4B5E");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CD7FC84E12");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.Weight)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
