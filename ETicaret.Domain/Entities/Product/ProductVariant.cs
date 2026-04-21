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

    private int _stock;
    public int Stock
    {
        get => _stock;
        set => _stock = value < 0 ? throw new DomainException("Stok negatif olamaz.") : value;
    }

    // Navigation Properties
    public Product Product { get; set; } = null!;
    public Color Color { get; set; } = null!;
    public Size Size { get; set; } = null!;
}
