namespace DhartiMaaMvcCoreProject.Models
{
    public class Product
    {
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

    }
}
