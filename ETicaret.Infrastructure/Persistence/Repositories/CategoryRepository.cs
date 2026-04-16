using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Category;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Category>> GetSubCategoriesAsync(Guid parentId)
        => await _dbSet.Where(c => c.ParentCategoryId == parentId).ToListAsync();

    // ParentCategoryId null olanlar → kök kategoriler (Kadın, Erkek, Çocuk)
    public async Task<IEnumerable<Category>> GetRootCategoriesAsync()
        => await _dbSet.Where(c => c.ParentCategoryId == null).ToListAsync();
}
