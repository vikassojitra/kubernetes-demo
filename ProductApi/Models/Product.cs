namespace ProductApi.Models
{
    public class Product
    {
        public string Version { get; set; } = "Version-1";
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public int StockQuantity { get; set; }

        public DateTime ManufactureDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public bool IsActive { get; set; }
    }
}
