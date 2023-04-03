using Products.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using Products.Domain.Entities;

namespace Products.Persistence
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
           : base(options)
        {
        }

        public DbSet<Branche> Branches { get; set; }
        public DbSet<Employe> Employes { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeProduct> SizeProduct { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var categoryGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var postGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            //modelBuilder.Entity<Category>().HasData(new Category
            //{
            //    Id = categoryGuid,
            //    Name = "Technology"
            //});

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = postGuid,
                Name = "Malk",
                Description = "Lorem ipsum dolor sit amet, consectetur",
        
            });

        }
    }

}
