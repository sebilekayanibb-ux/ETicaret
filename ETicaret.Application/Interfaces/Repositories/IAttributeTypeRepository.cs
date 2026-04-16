using ETicaret.Domain.Entities.Product;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IAttributeTypeRepository : IGenericRepository<AttributeType>
{
    Task<AttributeType?> GetWithValuesAsync(Guid id);
}
