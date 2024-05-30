using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp5byKrisha.Models;

public partial class NcclabkrishaContext : DbContext
{
    public NcclabkrishaContext()
    {
    }

    public NcclabkrishaContext(DbContextOptions<NcclabkrishaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<College> Colleges { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("server=DESKTOP-J71DMHM; database=ncclabkrisha; trusted_connection=true; TrustServerCertificate=true; Integrated Security=SSPI;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(60);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("students");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Stream)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stream");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
