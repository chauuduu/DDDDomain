using Application.ViewModel;
using Domain.Cloth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace Application.Data
{
    public class MyDbContext : DbContext
    {

        public  DbSet<Clothes> Clothes { get; set; }
        public  DbSet<TypeClothes> TypeClothes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeClothes>()
                .HasMany(c => c.Clothes)
                .WithOne(e => e.TypeClothes)
            .HasForeignKey(s => s.TypeClothesId);
        }

        private const string connectionString = @"Server=DESKTOP-FF1278R;Database=ClothesShop;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
