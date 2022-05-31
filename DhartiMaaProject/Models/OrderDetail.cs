using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            OrderItems = new HashSet<OrderItem>();
            PaymentDetails = new HashSet<PaymentDetail>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public double? Total { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
