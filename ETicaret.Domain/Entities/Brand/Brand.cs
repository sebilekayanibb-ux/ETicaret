using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Brand;

public class Brand : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? LogoUrl { get; set; }

    // Navigation Properties
    public ICollection<Product.Product> Products { get; set; } = [];
}
