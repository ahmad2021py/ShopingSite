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

    }
}
