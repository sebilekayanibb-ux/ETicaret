using ETicaret.Domain.Enums;

namespace ETicaret.Application.DTOs.Return
{
    public class CreateReturnDto
    {
        public Guid OrderId { get; set; }
        public string ReturnReason { get; set; } = string.Empty;
        public ReturnMethod RefundMethod { get; set; }
        public List<ReturnOrderItemDto> Items { get; set; } = new();
    }

    public class ReturnOrderItemDto
    {
        public Guid OrderItemId { get; set; }
        public int Quantity { get; set; }
    }
}
