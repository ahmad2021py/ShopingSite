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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Seed Data Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "Asp.Net Core",
                Description = "Asp.Net Core 3"
            },
                new Category()
                {
                    Id = 2,
                    Name = "لباس ورزشی",
                    Description = "گروه لباس ورزشی"
                },
                new Category()
                {
                    Id = 3,
                    Name = "ساعت مچی",
                    Description = "ساعت مچی"
                },
                new Category()
                {
                    Id = 4,
                    Name = "لوازم منزل",
                    Description = "لوازم منزل"
                }
            );

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
