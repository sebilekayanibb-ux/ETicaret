using ETicaret.Domain.Common;
using ETicaret.Domain.Enums;

namespace ETicaret.Domain.Entities.ReturnOrder;

public class ReturnOrder : BaseEntity
{
    public Guid OrderId { get; set; }
    public string ReturnCode { get; set; } = string.Empty;
    public string ReturnReason { get; set; } = string.Empty;
    public ReturnStatus Status { get; set; } = ReturnStatus.Requested;
    public string? CargoCompany { get; set; }
    public string? TrackingNumber { get; set; }
    public decimal RefundAmount { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string? RejectionReason { get; set; }
    public ReturnMethod? RefundMethod { get; set; }

    // Navigation Properties
    public Order.Order Order { get; set; } = null!;
    public ICollection<ReturnOrderItem> ReturnOrderItems { get; set; } = [];
}
