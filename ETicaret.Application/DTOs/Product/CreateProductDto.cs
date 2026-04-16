
namespace ETicaret.Application.DTOs.Product
{
    public class CreateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Seller { get; set; } // Eğer alt marka varsa
        public decimal ListPrice { get; set; }
        public decimal SalePrice { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
