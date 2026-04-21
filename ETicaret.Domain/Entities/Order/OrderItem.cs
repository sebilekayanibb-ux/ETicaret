using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Order;

public class OrderItem : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductVariantId { get; set; }

    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set => _quantity = value <= 0 ? throw new DomainException("Adet 0'dan büyük olmalıdır.") : value;
    }

    private decimal _unitPrice;
    public decimal UnitPrice
    {
        get => _unitPrice;
        set => _unitPrice = value < 0 ? throw new DomainException("Birim fiyat negatif olamaz.") : value;
    }

    // Snapshot - sipariş anındaki bilgiler (ürün silinse bile korunur)
    public string ProductName { get; set; } = string.Empty;
    public string? ColorName { get; set; }
    public string? SizeName { get; set; }
    public string? ImageUrl { get; set; }

    // Navigation Properties
    public Order Order { get; set; } = null!;
    public Product.ProductVariant ProductVariant { get; set; } = null!;
}
