using ETicaret.Domain.Entities.ReturnOrder;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IReturnOrderRepository : IGenericRepository<ReturnOrder>
{
    Task<IEnumerable<ReturnOrder>> GetByOrderIdAsync(Guid orderId);
    Task<ReturnOrder?> GetByReturnCodeAsync(string returnCode);
}
