using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class Color : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string HexCode { get; set; } = string.Empty;

    // Navigation Properties
    public ICollection<ProductVariant> ProductVariants { get; set; } = [];
}
