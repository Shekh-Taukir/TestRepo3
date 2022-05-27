using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class PaymentDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? Amount { get; set; }
        public string? PaymentApiId { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual OrderDetail? Order { get; set; }
    }
}
