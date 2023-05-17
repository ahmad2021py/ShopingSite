using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Models
{
    public class Cart
    {

        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public int OrderId { get; set; }
        public List<CartItem> CartItems { get; set; }

        public void AddItem(CartItem item)
        {
            if (CartItems.Exists(n => n.Item.Id == item.Item.Id))
            {
                CartItems.Find(n => n.Item.Id == item.Item.Id).Quantity += 1;
            }

            else
            {

                CartItems.Add(item);
            }
        }
        public void Remove(int itemId)
        {
            var item = CartItems.SingleOrDefault(n => n.Item.Id == itemId);
            if (item!=null&& item.Quantity <=1 )
            {
                CartItems.Remove(item);
            }
            else if (item != null) 
            {
                item.Quantity -= 1;
            }


        }

    }
}
