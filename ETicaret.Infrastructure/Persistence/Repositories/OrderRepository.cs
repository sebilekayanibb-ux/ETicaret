using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Order;
using ETicaret.Domain.Entities.ReturnOrder;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Order?> GetWithDetailsAsync(Guid id)
        => await _dbSet
            .Include(o => o.OrderItems).ThenInclude(oi => oi.ProductVariant)
            .Include(o => o.Payment)
            .Include(o => o.ShippingAddress)
            .Include(o => o.BillingAddress)
            .FirstOrDefaultAsync(o => o.Id == id);

    public async Task<IEnumerable<Order>> GetByUserIdAsync(Guid userId)
        => await _dbSet.Where(o => o.UserId == userId)
                       .OrderByDescending(o => o.OrderDate)
                       .ToListAsync();

    public async Task<Order?> GetByOrderNumberAsync(string orderNumber)
        => await _dbSet.FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);
}

public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Payment?> GetByOrderIdAsync(Guid orderId)
        => await _dbSet.FirstOrDefaultAsync(p => p.OrderId == orderId);
}

public class ReturnOrderRepository : GenericRepository<ReturnOrder>, IReturnOrderRepository
{
    public ReturnOrderRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<ReturnOrder>> GetByOrderIdAsync(Guid orderId)
        => await _dbSet.Where(r => r.OrderId == orderId).ToListAsync();

    public async Task<ReturnOrder?> GetByReturnCodeAsync(string returnCode)
        => await _dbSet.FirstOrDefaultAsync(r => r.ReturnCode == returnCode);
}
