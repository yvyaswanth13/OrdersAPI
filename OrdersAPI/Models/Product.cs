using System;
using System.Collections.Generic;

#nullable disable

namespace OrdersAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Offers = new HashSet<Offer>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int? StorageId { get; set; }
        public string Category { get; set; }
        public int? Price { get; set; }
        public string Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual Storage Storage { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
