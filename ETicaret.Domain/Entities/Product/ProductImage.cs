using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class ProductImage : BaseEntity
{
    public Guid ProductId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public int SortOrder { get; set; }
    public bool IsCover { get; set; } = false;

    // Navigation Properties
    public Product Product { get; set; } = null!;
}
