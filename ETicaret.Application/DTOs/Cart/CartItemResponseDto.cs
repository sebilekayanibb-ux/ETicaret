namespace ETicaret.Application.DTOs.Cart
{
    public class CartItemResponseDto
    {
        public Guid Id { get; set; }                      // CartItem.Id
        public Guid ProductVariantId { get; set; }

        // Ürün bilgileri
        public string ProductName { get; set; } = string.Empty;
        public string BrandName { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }             // IsCover=true olan resim

        // Varyant bilgileri
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }
        public string? Length { get; set; }

        // Fiyat bilgileri
        public decimal ListPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }           // SalePrice × Quantity
    }
}