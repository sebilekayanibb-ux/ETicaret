using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class Size : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    // Navigation Properties
    public ICollection<ProductVariant> ProductVariants { get; set; } = [];
}
