using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClothesRentalShop;

public partial class ClothesShopContext : DbContext
{
    public ClothesShopContext()
    {
    }

    public ClothesShopContext(DbContextOptions<ClothesShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Clothe> Clothes { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DetailInvoice> DetailInvoices { get; set; }

    public virtual DbSet<DetailInvoiceLaundry> DetailInvoiceLaundries { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Laundry> Laundries { get; set; }

    public virtual DbSet<LaundryInvoice> LaundryInvoices { get; set; }

    public virtual DbSet<Origin> Origins { get; set; }

    public virtual DbSet<RoleStaff> RoleStaffs { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<TypeClothe> TypeClothes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FF1278R;Database=ClothesShop;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Clothe>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Origin).WithMany(p => p.Clothes)
                .HasForeignKey(d => d.OriginId)
                .HasConstraintName("FK_Clothes_Origin");

            entity.HasOne(d => d.TypeClothes).WithMany(p => p.Clothes)
                .HasForeignKey(d => d.TypeClothesId)
                .HasConstraintName("FK_Clothes_TypeClothes1");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<DetailInvoice>(entity =>
        {
            entity.ToTable("DetailInvoice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idclothes).HasColumnName("IDClothes");
            entity.Property(e => e.Idinvoice).HasColumnName("IDInvoice");

            entity.HasOne(d => d.IdclothesNavigation).WithMany(p => p.DetailInvoices)
                .HasForeignKey(d => d.Idclothes)
                .HasConstraintName("FK_DetailInvoice_Clothes");

            entity.HasOne(d => d.IdinvoiceNavigation).WithMany(p => p.DetailInvoices)
                .HasForeignKey(d => d.Idinvoice)
                .HasConstraintName("FK_DetailInvoice_Invoice");
        });

        modelBuilder.Entity<DetailInvoiceLaundry>(entity =>
        {
            entity.ToTable("DetailInvoiceLaundry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idclothes).HasColumnName("IDClothes");
            entity.Property(e => e.IdlaundryInvoice).HasColumnName("IDLaundryInvoice");

            entity.HasOne(d => d.IdclothesNavigation).WithMany(p => p.DetailInvoiceLaundries)
                .HasForeignKey(d => d.Idclothes)
                .HasConstraintName("FK_DetailInvoiceLaundry_Clothes");

            entity.HasOne(d => d.IdlaundryInvoiceNavigation).WithMany(p => p.DetailInvoiceLaundries)
                .HasForeignKey(d => d.IdlaundryInvoice)
                .HasConstraintName("FK_DetailInvoiceLaundry_LaundryInvoice");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("Invoice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Idcustomer).HasColumnName("IDCustomer");
            entity.Property(e => e.Idstaff).HasColumnName("IDStaff");

            entity.HasOne(d => d.IdcustomerNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.Idcustomer)
                .HasConstraintName("FK_Invoice_Customer");

            entity.HasOne(d => d.IdstaffNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.Idstaff)
                .HasConstraintName("FK_Invoice_Staff");
        });

        modelBuilder.Entity<Laundry>(entity =>
        {
            entity.ToTable("Laundry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<LaundryInvoice>(entity =>
        {
            entity.ToTable("LaundryInvoice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Idlaundry).HasColumnName("IDLaundry");
            entity.Property(e => e.Idstaff).HasColumnName("IDStaff");

            entity.HasOne(d => d.IdlaundryNavigation).WithMany(p => p.LaundryInvoices)
                .HasForeignKey(d => d.Idlaundry)
                .HasConstraintName("FK_LaundryInvoice_Laundry");

            entity.HasOne(d => d.IdstaffNavigation).WithMany(p => p.LaundryInvoices)
                .HasForeignKey(d => d.Idstaff)
                .HasConstraintName("FK_LaundryInvoice_Staff");
        });

        modelBuilder.Entity<Origin>(entity =>
        {
            entity.ToTable("Origin");

            entity.Property(e => e.OriginId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RoleStaff>(entity =>
        {
            entity.HasKey(e => e.Idrole);

            entity.ToTable("RoleStaff");

            entity.Property(e => e.Idrole).HasColumnName("IDRole");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Birthday).HasColumnType("date");
            entity.Property(e => e.Cccd)
                .HasMaxLength(50)
                .HasColumnName("CCCD");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Idrole).HasColumnName("IDRole");
            entity.Property(e => e.Phone).HasMaxLength(50);

            entity.HasOne(d => d.IdroleNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.Idrole)
                .HasConstraintName("FK_Staff_RoleStaff");
        });

        modelBuilder.Entity<TypeClothe>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
