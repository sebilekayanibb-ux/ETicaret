using ETicaret.Domain.Enums;

namespace ETicaret.Application.DTOs.Order
{ //Sipariş listesi ("Siparişlerim") için kullanılacak DTO
    public class OrderResponseDto
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        public decimal GrandTotal { get; set; }
        public int TotalItems { get; set; }

        // Listede gösterilecek ilk ürün görseli
        public string? FirstProductImageUrl { get; set; }
    }
}