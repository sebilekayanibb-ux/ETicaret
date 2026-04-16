using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Brand;
using ETicaret.Infrastructure.Persistence.Context;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class BrandRepository : GenericRepository<Brand>, IBrandRepository
{
    public BrandRepository(AppDbContext context) : base(context)
    {
    }
}
