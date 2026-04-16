using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Product;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class ProductVariantRepository : GenericRepository<ProductVariant>, IProductVariantRepository
{
    public ProductVariantRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<ProductVariant>> GetByProductIdAsync(Guid productId)
        => await _dbSet.Include(pv => pv.Color)
                       .Include(pv => pv.Size)
                       .Where(pv => pv.ProductId == productId)
                       .ToListAsync();

    public async Task<ProductVariant?> GetBySkuAsync(string sku)
        => await _dbSet.FirstOrDefaultAsync(pv => pv.SKU == sku);
}

public class ColorRepository : GenericRepository<Color>, IColorRepository
{
    public ColorRepository(AppDbContext context) : base(context)
    {
    }
}

public class SizeRepository : GenericRepository<Size>, ISizeRepository
{
    public SizeRepository(AppDbContext context) : base(context)
    {
    }
}

public class AttributeTypeRepository : GenericRepository<AttributeType>, IAttributeTypeRepository
{
    public AttributeTypeRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<AttributeType?> GetWithValuesAsync(Guid id)
        => await _dbSet.Include(at => at.AttributeValues)
                       .FirstOrDefaultAsync(at => at.Id == id);
}

public class AttributeValueRepository : GenericRepository<AttributeValue>, IAttributeValueRepository
{
    public AttributeValueRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<AttributeValue>> GetByAttributeTypeIdAsync(Guid attributeTypeId)
        => await _dbSet.Where(av => av.AttributeTypeId == attributeTypeId).ToListAsync();
}
