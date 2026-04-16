using ETicaret.Domain.Entities.Order;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IPaymentRepository : IGenericRepository<Payment>
{
    Task<Payment?> GetByOrderIdAsync(Guid orderId);
}
