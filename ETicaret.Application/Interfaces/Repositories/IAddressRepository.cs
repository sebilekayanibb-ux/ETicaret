using ETicaret.Domain.Entities.Address;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IAddressRepository : IGenericRepository<Address>
{
    Task<IEnumerable<Address>> GetByUserIdAsync(Guid userId);
}
