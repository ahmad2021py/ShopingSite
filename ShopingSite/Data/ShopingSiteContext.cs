using Microsoft.EntityFrameworkCore;
using ShopingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Data
{
    public class ShopingSiteContext:DbContext // attachment 1
    {
        public ShopingSiteContext(DbContextOptions<ShopingSiteContext> options) : base(options)
        {



        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>()
               .HasKey(t => new { t.ProductId, t.CategoryId });

         
            

            modelBuilder.Entity<Item>(i =>
            {
                i.Property(w => w.Price).HasColumnType("Money");
                i.HasKey(w => w.Id);
            });
          

            #region Seed Data Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                
               
            },
                new Category()
                {
                   
                },
                new Category()
                {
                   
                },
                new Category()
                {
                  
                }
            );
            #endregion


            #region Seed Data Item
            modelBuilder.Entity<Item>().HasData(
                new Item()
                {
                    
                },
            new Item()
            {
                
            },
            new Item()
            {
                
            });
            #endregion


            #region Seed Data Product
            modelBuilder.Entity<Product>().HasData(new Product()
            {
            
            },
                new Product()
                {
                 
                },
                new Product()
                {
                   
                });



            #endregion

            modelBuilder.Entity<CategoryToProduct>().HasData(
              new CategoryToProduct() { CategoryId = 1, ProductId = 1 },
              new CategoryToProduct() { CategoryId = 2, ProductId = 1 },
              new CategoryToProduct() { CategoryId = 3, ProductId = 1 },
              new CategoryToProduct() { CategoryId = 4, ProductId = 1 },
              new CategoryToProduct() { CategoryId = 1, ProductId = 2 },
              new CategoryToProduct() { CategoryId = 2, ProductId = 2 },
              new CategoryToProduct() { CategoryId = 3, ProductId = 2 },
              new CategoryToProduct() { CategoryId = 4, ProductId = 2 },
              new CategoryToProduct() { CategoryId = 1, ProductId = 3 },
              new CategoryToProduct() { CategoryId = 2, ProductId = 3 },
              new CategoryToProduct() { CategoryId = 3, ProductId = 3 },
              new CategoryToProduct() { CategoryId = 4, ProductId = 3 }
              );

            base.OnModelCreating(modelBuilder);
        }
    }
}
