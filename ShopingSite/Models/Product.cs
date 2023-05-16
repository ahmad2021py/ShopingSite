using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Models
{
    public class Product
    {
        public Product()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public  int Description { get; set; }

        public List<Category> Categories { get; set; }

    }
}
