using ETicaret.Domain.Entities.Address;
using ETicaret.Domain.Entities.Brand;
using ETicaret.Domain.Entities.Cart;
using ETicaret.Domain.Entities.Category;
using ETicaret.Domain.Entities.Order;
using ETicaret.Domain.Entities.Product;
using ETicaret.Domain.Entities.ReturnOrder;
using ETicaret.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Infrastructure.Persistence.Context;

// AppDbContext → EF Core'a "bu entity'ler şu tablolara gidecek" der
// DbContext'ten kalıtım alır, bu EF Core'un ana sınıfı
public class AppDbContext : DbContext
{
    // DbContextOptions → bağlantı dizesi, provider (SqlServer) gibi ayarları taşır
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Her DbSet → veritabanında bir tablo demektir
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<AttributeType> AttributeTypes { get; set; }
    public DbSet<AttributeValue> AttributeValues { get; set; }
    public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<ReturnOrder> ReturnOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Tüm Configuration sınıflarını otomatik olarak tarar ve uygular
        // Her entity için ayrı ayrı modelBuilder.ApplyConfiguration(...) yazmak yerine
        // bu tek satır, bu assembly içindeki tüm IEntityTypeConfiguration sınıflarını bulur
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    // SaveChangesAsync → veritabanına yazmadan önce UpdatedAt alanını otomatik set eder
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Modified);

        foreach (var entry in entries)
        {
            if (entry.Entity is ETicaret.Domain.Common.BaseEntity entity)
                entity.UpdatedAt = DateTime.UtcNow;
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
