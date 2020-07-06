using System;

namespace Restaurant.Models.AppModels
{
    public class CartItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Removed { get; set; }
        public bool Ordered { get; set; }
        public int OrderId { get; set; }
        public string Details { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }


    }
}