using System;
using System.Collections.Generic;

namespace DhartiMaaProject.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderItems = new HashSet<OrderItem>();
            ProductPictureMappings = new HashSet<ProductPictureMapping>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ProductDesc { get; set; }
        public string ProductSku { get; set; } = null!;
        public double? Price { get; set; }
        public int? CategoryId { get; set; }
        public int? InventoryId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? DiscountId { get; set; }

        public virtual ProductCategory? Category { get; set; }
        public virtual Discount? Discount { get; set; }
        public virtual ProductInventory? Inventory { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; }
    }
}
