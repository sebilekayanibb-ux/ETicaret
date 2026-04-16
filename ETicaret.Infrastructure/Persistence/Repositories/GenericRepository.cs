using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Common;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicaret.Infrastructure.Persistence.Repositories;

// T : BaseEntity → sadece BaseEntity'den türeyen sınıflar kullanabilir
public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        // DbSet<T> → EF Core'un ilgili tabloyu temsil eden nesnesi
        _dbSet = context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id)
        => await _dbSet.FindAsync(id);

    public async Task<IEnumerable<T>> GetAllAsync()
        => await _dbSet.ToListAsync();

    // Expression → LINQ sorgusu parametre olarak geçilir
    // Örn: GetWhereAsync(u => u.Email == "test@test.com")
    public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        => await _dbSet.Where(predicate).ToListAsync();

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        => await _dbSet.AnyAsync(predicate);

    public async Task AddAsync(T entity)
        => await _dbSet.AddAsync(entity);

    // Update ve Delete → async değil çünkü veritabanına gitmez
    // Sadece EF Core'un takip listesini günceller, SaveChanges ile işlenir
    public void Update(T entity)
        => _dbSet.Update(entity);

    public void Delete(T entity)
    {
        // Hard delete yerine soft delete → IsDeleted = true yapar, veriyi silmez
        entity.IsDeleted = true;
        _dbSet.Update(entity);
    }
}
