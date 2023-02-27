
using Domain.Cloth;
using Domain.Customers;
using Domain.Invoices;
using Domain.Laundries;
using Domain.LaundryInvoices;
using Domain.Staffs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace ClothesRentalShop
{
    public class MyDbContext : DbContext
    {

        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<DetailInvoice> DetailInvoices { get; set; }

        public DbSet<DetailInvoiceLaundry> DetailInvoiceLaundries { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Laundry> Laundries { get; set; }

        public DbSet<LaundryInvoice> LaundryInvoices { get; set; }

        public DbSet<Origin> Origins { get; set; }

        public DbSet<RoleStaff> RoleStaffs { get; set; }

        public DbSet<Staff> Staff { get; set; }
        public DbSet<TypeClothes> TypeClothes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothes>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.TypeClothes).WithMany(p => p.Clothes)
                    .HasForeignKey(d => d.TypeClothesId)
                    .HasConstraintName("FK_Clothes_TypeClothes");
            });

            modelBuilder.Entity<TypeClothes>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

        }


        private const string connectionString = @"Server=DESKTOP-FF1278R;Database=ClothesShop;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
