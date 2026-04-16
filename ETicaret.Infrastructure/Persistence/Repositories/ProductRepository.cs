using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Product;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }

    // Ürün detay sayfası → tüm ilişkili verilerle birlikte getir
    public async Task<Product?> GetWithDetailsAsync(Guid id)
        => await _dbSet
            .Include(p => p.Brand)
            .Include(p => p.Category)
            .Include(p => p.Images)
            .Include(p => p.Variants).ThenInclude(v => v.Color)
            .Include(p => p.Variants).ThenInclude(v => v.Size)
            .Include(p => p.AttributeValues).ThenInclude(av => av.AttributeValue)
                .ThenInclude(av => av.AttributeType)
            .FirstOrDefaultAsync(p => p.Id == id);

    public async Task<IEnumerable<Product>> GetByCategoryAsync(Guid categoryId)
        => await _dbSet.Where(p => p.CategoryId == categoryId).ToListAsync();

    public async Task<IEnumerable<Product>> GetByBrandAsync(Guid brandId)
        => await _dbSet.Where(p => p.BrandId == brandId).ToListAsync();
}
