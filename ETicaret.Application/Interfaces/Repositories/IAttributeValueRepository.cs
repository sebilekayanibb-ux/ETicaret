using ETicaret.Domain.Entities.Product;

namespace ETicaret.Application.Interfaces.Repositories;

public interface IAttributeValueRepository : IGenericRepository<AttributeValue>
{
    Task<IEnumerable<AttributeValue>> GetByAttributeTypeIdAsync(Guid attributeTypeId);
}
