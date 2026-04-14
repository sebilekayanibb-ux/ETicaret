using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Order;

public class OrderItem : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductVariantId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    // Navigation Properties
    public Order Order { get; set; } = null!;
    public Product.ProductVariant ProductVariant { get; set; } = null!;
}
