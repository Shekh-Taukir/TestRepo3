using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? DiscountName { get; set; }
        public string? DiscountDesc { get; set; }
        public double? DiscountPercent { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
