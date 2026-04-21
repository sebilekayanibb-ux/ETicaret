using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Cart;

public class CartItem : BaseEntity
{
    public Guid CartId { get; set; }
    public Guid ProductVariantId { get; set; }

    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set => _quantity = value <= 0 ? throw new DomainException("Adet 0'dan büyük olmalıdır.") : value;
    }

    // Navigation Properties
    public Cart Cart { get; set; } = null!;
    public Product.ProductVariant ProductVariant { get; set; } = null!;
}
