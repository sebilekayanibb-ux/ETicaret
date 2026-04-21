namespace ETicaret.Application.DTOs.Order
{
    public class OrderItemDto
    {
        public Guid ProductVariantId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }
        public string? ImageUrl { get; set; }

        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }  // UnitPrice × Quantity
    }
}