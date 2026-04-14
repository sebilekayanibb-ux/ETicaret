using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Cart;

public class CartItem : BaseEntity
{
    public Guid CartId { get; set; }
    public Guid ProductVariantId { get; set; }
    public int Quantity { get; set; }

    // Navigation Properties
    public Cart Cart { get; set; } = null!;
    public Product.ProductVariant ProductVariant { get; set; } = null!;
}
