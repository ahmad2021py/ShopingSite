﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Models
{
    public class Item
    {


        public int Id { get; set; }
      
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        //Relationship 
        public Product Product { get; set; }


    }
}
