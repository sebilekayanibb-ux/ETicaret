using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
    public Guid BrandId { get; set; }
    public string? Description { get; set; }
    public string? Seller { get; set; }
    public decimal ListPrice { get; set; }
    public decimal SalePrice { get; set; }
    public bool IsActive { get; set; } = true;

    // Navigation Properties
    public Category.Category Category { get; set; } = null!;
    public Brand.Brand Brand { get; set; } = null!;
    public ICollection<ProductVariant> Variants { get; set; } = [];
    public ICollection<ProductImage> Images { get; set; } = [];
}
