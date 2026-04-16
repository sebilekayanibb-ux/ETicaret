using ETicaret.Application.Interfaces;
using ETicaret.Application.Interfaces.Repositories;
using ETicaret.Infrastructure.Persistence.Context;
using ETicaret.Infrastructure.Persistence.Repositories;

namespace ETicaret.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    // Lazy initialization → repository ilk kullanıldığında oluşturulur
    public IUserRepository Users { get; }
    public IAddressRepository Addresses { get; }
    public IBrandRepository Brands { get; }
    public ICategoryRepository Categories { get; }
    public IProductRepository Products { get; }
    public IProductVariantRepository ProductVariants { get; }
    public IColorRepository Colors { get; }
    public ISizeRepository Sizes { get; }
    public IAttributeTypeRepository AttributeTypes { get; }
    public IAttributeValueRepository AttributeValues { get; }
    public ICartRepository Carts { get; }
    public IOrderRepository Orders { get; }
    public IPaymentRepository Payments { get; }
    public IReturnOrderRepository ReturnOrders { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        // Tüm repository'lere aynı DbContext instance'ını veriyoruz
        // Bu sayede hepsi aynı transaction üzerinde çalışır
        Users = new UserRepository(context);
        Addresses = new AddressRepository(context);
        Brands = new BrandRepository(context);
        Categories = new CategoryRepository(context);
        Products = new ProductRepository(context);
        ProductVariants = new ProductVariantRepository(context);
        Colors = new ColorRepository(context);
        Sizes = new SizeRepository(context);
        AttributeTypes = new AttributeTypeRepository(context);
        AttributeValues = new AttributeValueRepository(context);
        Carts = new CartRepository(context);
        Orders = new OrderRepository(context);
        Payments = new PaymentRepository(context);
        ReturnOrders = new ReturnOrderRepository(context);
    }

    // Tüm değişiklikleri tek seferde veritabanına yazar
    public async Task<int> SaveChangesAsync()
        => await _context.SaveChangesAsync();

    public void Dispose()
        => _context.Dispose();
}
