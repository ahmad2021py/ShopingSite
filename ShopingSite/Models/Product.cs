using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Models
{
    public class Product
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Description { get; set; }
        public int ItemId { get; set; }//  Foreign Key of Item Table

        //Relationship 
        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }
        public Item Item { get; set; }

    }
}
