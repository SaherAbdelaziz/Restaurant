using System.Collections.Generic;

namespace Restaurant.Models.AppModels
{
    public class Cart
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string SessionId { get; set; }
        public double TotalPrice { get; set; }
        public double Delivery { get; set; }
        private List<CartItem> _cartItems;
        public bool Ordered { get; set; }
        public int OrderId { get; set; }

        public Cart()
        {
            _cartItems = new List<CartItem>();
        }
        
    }
}