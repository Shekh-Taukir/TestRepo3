using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class ProductInventory
    {
        public ProductInventory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
