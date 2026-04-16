
namespace ETicaret.Application.DTOs.Product
{
    public class ProductResponseDto
    {
        /// Ürün listesinde her kart için dönen özet veri.
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal ListPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string? CoverImageUrl { get; set; }
        public int? DiscountPercentage { get; set; } // İndirim yüzdesi 
        public string BrandName { get; set; } = string.Empty;
        public bool IsActive { get; set; }

    }
}
