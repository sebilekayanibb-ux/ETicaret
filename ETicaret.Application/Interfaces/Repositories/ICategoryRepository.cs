using ETicaret.Domain.Entities.Category;

namespace ETicaret.Application.Interfaces.Repositories;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<IEnumerable<Category>> GetSubCategoriesAsync(Guid parentId);
    Task<IEnumerable<Category>> GetRootCategoriesAsync();
}
