using ETicaret.Domain.Enums;

namespace ETicaret.Application.DTOs.Order
{ // Sipariş oluşturma için gerekli bilgileri içeren DTO
    public class CreateOrderDto
    {
        public Guid ShippingAddressId { get; set; }
        public Guid BillingAddressId { get; set; }
        public bool IsBillingSameAsShipping { get; set; } = true;

        public PaymentMethod PaymentMethod { get; set; }
        public DeliveryType DeliveryType { get; set; }

        public string? CouponCode { get; set; }
        public int InstallmentCount { get; set; } = 1;
    }
}