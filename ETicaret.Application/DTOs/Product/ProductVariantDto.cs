
namespace ETicaret.Application.DTOs.Product
{
    public class ProductVariantDto
    {
        public Guid Id { get; set; }
        public string Color { get; set; } = string.Empty;
        public string ColorHex { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string? Length { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }
        public string SKU { get; set; } = string.Empty; // Benzersiz ürün kodu
    }
}
