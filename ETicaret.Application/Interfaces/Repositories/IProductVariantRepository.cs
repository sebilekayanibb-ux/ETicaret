using ETicaret.Domain.Entities.Product;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IProductVariantRepository : IGenericRepository<ProductVariant>
{
    Task<IEnumerable<ProductVariant>> GetByProductIdAsync(Guid productId);
    Task<ProductVariant?> GetBySkuAsync(string sku);
}
