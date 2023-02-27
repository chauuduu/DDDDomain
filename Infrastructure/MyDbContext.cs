
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
namespace Infrastructure
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
            //data seeding
            modelBuilder.Entity<Clothes>().HasData(
                new { Id =1, Name = "Váy công sở Zara", Description = "Màu trắng", Size = Size.Large, Price = 89.99m, RentalTime = 0, RentalPrice = 200000, TypeClothesId = 1, OriginId = 1, Status = Status.Available },
                new { Id=2, Name = "Áo công sở Uniqlo", Description = "Màu đen", Size = Size.Medium, Price = 58.99m, RentalTime = 0, RentalPrice = 100000, TypeClothesId = 2, OriginId = 2, Status = Status.Available }
                );
            modelBuilder.Entity<TypeClothes>().HasData(
                new { Id=1, Name = "Váy", Limit = 15 },
                new { Id=2, Name = "Áo", Limit = 20 }
                );
            modelBuilder.Entity<Origin>().HasData(
                new { Id = 1, Name = "Zara", Address = "Korea" },
                new { Id = 2, Name = "Uniqlo", Address = "Japan" }
                );
            modelBuilder.Entity<Customer>().HasData(
                new { Id = 1, FullName = "Chau Hoang Bich Du", Phone="0943357474", Address="32 Nguyen Hue Str, Hue" },
                new { Id = 2, FullName = "Chau Chi Khanh", Phone = "0935727272", Address = "42 Nguyen Hue Str, Ha Noi" }
                );
            modelBuilder.Entity<DetailInvoice>().HasData(
                new { Id = 1, InvoiceId=1, ClothesId=1,Quantity=1},
                new { Id = 2, InvoiceId = 1, ClothesId = 2, Quantity = 1 }
                );
            modelBuilder.Entity<Invoice>().HasData(
               new { Id = 1, Date = new DateTime(2023, 2, 1),CustomerId=1,StaffId=1,Discount=0}
               );
            modelBuilder.Entity<Laundry>().HasData(
                new { Id = 1, Name = "O Ti", Phone = "0943357373", Address = "56 Nguyen Hue Str, Hue",Rate=3 },
                new { Id = 2, Name = "O Mi", Phone = "0935727276", Address = "42 Hai Ba Trung Str, Hue",Rate=4 }
                );
            modelBuilder.Entity<DetailInvoiceLaundry>().HasData(
                new { Id = 1, LaundryInvoiceId = 1, ClothesId = 1, Quantity = 1, Price = 1.00m },
                new { Id = 2, LaundryInvoiceId = 1, ClothesId = 2, Quantity = 1, Price = 0.99m }
                );
            modelBuilder.Entity<LaundryInvoice>().HasData(
               new { Id = 1, Date = new DateTime(2023, 2, 3), LaundryId = 2, StaffId = 1 }
               );
            modelBuilder.Entity<RoleStaff>().HasData(
               new { Id = 1, Name="Admin" },
               new { Id = 2, Name = "Accountant" }
               );
            modelBuilder.Entity<Staff>().HasData(
               new { Id = 1, CitizenCode="04321842241", FullName = "Nguyen Thi Kim Tuyen",Birthday= new DateTime(2001, 2, 1), Phone = "0943357323", Address = "5/6 Nguyen Cong Tru Str, Hue", RoleId = 2 },
               new { Id = 2, CitizenCode = "04242144124", FullName = "Nguyen Van Tai", Birthday = new DateTime(1989, 2, 1), Phone = "0943357329", Address = "5/10 Nguyen Hue Str, Hue", RoleId = 1 }
               );

        }

        private const string connectionString = @"Server=DESKTOP-FF1278R;Database=ClothesShop;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
