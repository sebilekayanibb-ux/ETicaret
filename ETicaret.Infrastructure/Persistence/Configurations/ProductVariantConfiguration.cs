using ETicaret.Domain.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Infrastructure.Persistence.Configurations;

public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
{
    public void Configure(EntityTypeBuilder<ProductVariant> builder)
    {
        builder.ToTable("ProductVariants");

        builder.HasKey(pv => pv.Id);

        // SKU → her varyantın eşsiz ürün kodu olmalı (örn: LCW-001-RED-M)
        builder.Property(pv => pv.SKU).IsRequired().HasMaxLength(100);
        builder.HasIndex(pv => pv.SKU).IsUnique();

        builder.Property(pv => pv.Price).HasPrecision(18, 2);
        builder.Property(pv => pv.Length).HasMaxLength(50);

        builder.HasOne(pv => pv.Product)
            .WithMany(p => p.Variants)
            .HasForeignKey(pv => pv.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pv => pv.Color)
            .WithMany(c => c.ProductVariants)
            .HasForeignKey(pv => pv.ColorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(pv => pv.Size)
            .WithMany(s => s.ProductVariants)
            .HasForeignKey(pv => pv.SizeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(pv => !pv.IsDeleted);
    }
}
