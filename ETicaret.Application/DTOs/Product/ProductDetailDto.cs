

namespace ETicaret.Application.DTOs.Product
{
    public class ProductDetailDto
    {
        //Ürün detay sayfasında gösterilecek tüm bilgiler.
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public decimal ListPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;

        public List<ProductImageDto> Images { get; set; } = [];
        public List<ProductVariantDto> Variants { get; set; } = [];
        public List<ProductAttributeDto> Attributes { get; set; } = [];



    }
}
