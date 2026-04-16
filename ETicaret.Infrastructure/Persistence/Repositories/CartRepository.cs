using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Domain.Entities.Cart;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Repositories;

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(AppDbContext context) : base(context)
    {
    }

    // Sepeti kalemleri ve ürün detaylarıyla birlikte getir
    public async Task<Cart?> GetWithItemsAsync(Guid userId)
        => await _dbSet
            .Include(c => c.CartItems)
                .ThenInclude(ci => ci.ProductVariant)
                    .ThenInclude(pv => pv.Product)
            .Include(c => c.CartItems)
                .ThenInclude(ci => ci.ProductVariant)
                    .ThenInclude(pv => pv.Color)
            .Include(c => c.CartItems)
                .ThenInclude(ci => ci.ProductVariant)
                    .ThenInclude(pv => pv.Size)
            .FirstOrDefaultAsync(c => c.UserId == userId);
}
