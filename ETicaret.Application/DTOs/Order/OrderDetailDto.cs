using ETicaret.Application.DTOs.Address;
using ETicaret.Domain.Enums;


namespace ETicaret.Application.DTOs.Order
{
    public class OrderDetailDto
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        // Ürünler
        public List<OrderItemDto> Items { get; set; } = new();

        // Adresler
        public AddressResponseDto ShippingAddress { get; set; } = null!;
        public AddressResponseDto BillingAddress { get; set; } = null!;

        // Ödeme
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public int InstallmentCount { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }

        // Fiyat özeti
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal CouponDiscount { get; set; }
        public string? CouponCode { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
