using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Product;

public class ProductVariant : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid ColorId { get; set; }
    public Guid SizeId { get; set; }
    public string SKU { get; set; } = string.Empty;
    public decimal? Price { get; set; }
    public string? Length { get; set; }
    public int Stock { get; set; }

    // Navigation Properties
    public Product Product { get; set; } = null!;
    public Color Color { get; set; } = null!;
    public Size Size { get; set; } = null!;
}
