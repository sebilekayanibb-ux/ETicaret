using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Address;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class AddressRepository : GenericRepository<Address>, IAddressRepository
{
    public AddressRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Address>> GetByUserIdAsync(Guid userId)
        => await _dbSet.Where(a => a.UserId == userId).ToListAsync();
}
