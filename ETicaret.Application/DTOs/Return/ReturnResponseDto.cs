using ETicaret.Domain.Enums;

namespace ETicaret.Application.DTOs.Return
{
    // İadelerim sayfası
    public class ReturnResponseDto
    {
        public Guid Id { get; set; }
        public string ReturnCode { get; set; } = string.Empty;
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime? ReturnDate { get; set; }
        public ReturnStatus Status { get; set; }

        public string ReturnReason { get; set; } = string.Empty;
        public ReturnMethod? RefundMethod { get; set; }
        public decimal RefundAmount { get; set; }

        // Kargo bilgileri
        public string? CargoCompany { get; set; }
        public string? TrackingNumber { get; set; }

        // Red sebebi (iade reddedildiyse)
        public string? RejectionReason { get; set; }

        // İade edilen ürünler
        public List<ReturnItemResponseDto> Items { get; set; } = new();
    }

    public class ReturnItemResponseDto
    {
        public Guid OrderItemId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }
        public string? ImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
