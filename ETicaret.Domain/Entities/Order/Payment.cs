using ETicaret.Domain.Common;
using ETicaret.Domain.Enums;

namespace ETicaret.Domain.Entities.Order;

public class Payment : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid? BillingAddressId { get; set; }
    public PaymentMethod Method { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public string? BankName { get; set; }
    public string? CardLastFourDigits { get; set; }
    public int InstallmentCount { get; set; } = 1;
    public string? InvoiceNumber { get; set; }
    public bool IsBillingSameAsShipping { get; set; } = true;
    public int? CreditInstallmentCount { get; set; }
    public decimal? CreditInstallmentDifference { get; set; }
    public DeliveryType DeliveryType { get; set; } = DeliveryType.HomeDelivery;
    public DateTime? EstimatedDeliveryDate { get; set; }

    // Navigation Properties
    public Order Order { get; set; } = null!;
}
