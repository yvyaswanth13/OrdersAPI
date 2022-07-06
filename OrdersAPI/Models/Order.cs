using System;
using System.Collections.Generic;

#nullable disable

namespace OrdersAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public long OrderId { get; set; }
        public int UserId { get; set; }
        public int? DistinctItems { get; set; }//optional
        public int? TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public long? PaymentId { get; set; }
        public int? OfferId { get; set; }
        public DateTime? OrderedOn { get; set; }
        public bool? IsCancelled { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string OrderStatus { get; set; }

        public virtual Offer Offer { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
