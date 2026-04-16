using ETicaret.Domain.Entities.User;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetWithAddressesAsync(Guid id);
}
