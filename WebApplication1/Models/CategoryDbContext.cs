using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCoreApplication.Models
{
    public class CategoryDbContext : DbContext
    {
        public CategoryDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "category 1" });
            modelBuilder.Entity<Product>(
                entity =>
                {
                    entity.HasOne(d => d.Category)
                        .WithMany(p => p.Products)
                        .HasForeignKey("CategoryId");
                });
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "product 1", CategoryId = 1 },
                new Product { ProductId = 2, ProductName = "product 2", CategoryId = 1 });
        }

    }
}