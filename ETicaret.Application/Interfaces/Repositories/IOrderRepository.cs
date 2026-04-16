using ETicaret.Domain.Entities.Order;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<Order?> GetWithDetailsAsync(Guid id);
    Task<IEnumerable<Order>> GetByUserIdAsync(Guid userId);
    Task<Order?> GetByOrderNumberAsync(string orderNumber);
}
