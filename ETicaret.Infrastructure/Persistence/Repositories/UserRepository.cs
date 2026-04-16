using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.User;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<User?> GetByEmailAsync(string email)
        => await _dbSet.FirstOrDefaultAsync(u => u.Email == email);

    // Include → ilişkili tabloyu da çek (JOIN gibi)
    public async Task<User?> GetWithAddressesAsync(Guid id)
        => await _dbSet.Include(u => u.Addresses)
                       .FirstOrDefaultAsync(u => u.Id == id);
}
