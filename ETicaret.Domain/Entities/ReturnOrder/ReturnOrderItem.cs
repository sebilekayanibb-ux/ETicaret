using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.ReturnOrder;

public class ReturnOrderItem : BaseEntity
{
    public Guid ReturnOrderId { get; set; }
    public Guid OrderItemId { get; set; }

    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set => _quantity = value <= 0 ? throw new DomainException("İade adedi 0'dan büyük olmalıdır.") : value;
    }

    // Navigation Properties
    public ReturnOrder ReturnOrder { get; set; } = null!;
    public Order.OrderItem OrderItem { get; set; } = null!;
}
