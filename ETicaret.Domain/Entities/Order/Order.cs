using ETicaret.Domain.Common;
using ETicaret.Domain.Enums;

namespace ETicaret.Domain.Entities.Order;

public class Order : BaseEntity
{
    public Guid UserId { get; set; }
    public string OrderNumber { get; set; } = string.Empty;
    public decimal SubTotal { get; set; }
    public decimal GrandTotal { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Received;
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public string? OrderSummary { get; set; }
    public Guid ShippingAddressId { get; set; }
    public Guid BillingAddressId { get; set; }
    public decimal ShippingFee { get; set; }
    public decimal CashOnDeliveryFee { get; set; }
    public decimal DiscountAmount { get; set; }

    // Navigation Properties
    public User.User User { get; set; } = null!;
    public Address.Address ShippingAddress { get; set; } = null!;
    public Address.Address BillingAddress { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = [];
    public Payment Payment { get; set; } = null!;
    public ICollection<ReturnOrder.ReturnOrder> ReturnOrders { get; set; } = [];
}
