using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class ProductVariant : BaseEntity
{
    public Guid ProductId { get; set; }
    public string Color { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public string? Length { get; set; }
    public int Stock { get; set; }

    // Navigation Properties
    public Product Product { get; set; } = null!;
}
