using ETicaret.Application.Interfaces.Repositories;

namespace ETicaret.Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IAddressRepository Addresses { get; }
    IBrandRepository Brands { get; }
    ICategoryRepository Categories { get; }
    IProductRepository Products { get; }
    IProductVariantRepository ProductVariants { get; }
    IColorRepository Colors { get; }
    ISizeRepository Sizes { get; }
    IAttributeTypeRepository AttributeTypes { get; }
    IAttributeValueRepository AttributeValues { get; }
    ICartRepository Carts { get; }
    IOrderRepository Orders { get; }
    IPaymentRepository Payments { get; }
    IReturnOrderRepository ReturnOrders { get; }

    Task<int> SaveChangesAsync();
}
