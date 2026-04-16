using ETicaret.Domain.Entities.Cart;

namespace ETicaret.Application.Interfaces.Repositories;

public interface ICartRepository : IGenericRepository<Cart>
{
    Task<Cart?> GetWithItemsAsync(Guid userId);
}
