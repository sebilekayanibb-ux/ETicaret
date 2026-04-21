using ETicaret.Domain.Common;
using ETicaret.Domain.Enums;

namespace ETicaret.Domain.Entities.Order;

public class Order : BaseEntity
{
    public Guid UserId { get; set; }
    public string OrderNumber { get; set; } = string.Empty;

    private decimal _subTotal;
    public decimal SubTotal
    {
        get => _subTotal;
        set => _subTotal = value < 0 ? throw new DomainException("Ara toplam negatif olamaz.") : value;
    }

    private decimal _grandTotal;
    public decimal GrandTotal
    {
        get => _grandTotal;
        set => _grandTotal = value < 0 ? throw new DomainException("Genel toplam negatif olamaz.") : value;
    }
    public OrderStatus Status { get; set; } = OrderStatus.Received;
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public string? OrderSummary { get; set; }
    public Guid ShippingAddressId { get; set; }
    public Guid BillingAddressId { get; set; }
    public decimal ShippingFee { get; set; }
    public decimal CashOnDeliveryFee { get; set; }
    public decimal DiscountAmount { get; set; }
    public string? CouponCode { get; set; }
    public decimal CouponDiscount { get; set; }

    // Kargo bilgileri
    public string? CargoCompany { get; set; }
    public string? TrackingNumber { get; set; }
    public string? ShipmentNumber { get; set; }

    // Navigation Properties
    public User.User User { get; set; } = null!;
    public Address.Address ShippingAddress { get; set; } = null!;
    public Address.Address BillingAddress { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = [];
    public Payment Payment { get; set; } = null!;
    public ICollection<ReturnOrder.ReturnOrder> ReturnOrders { get; set; } = [];
}
