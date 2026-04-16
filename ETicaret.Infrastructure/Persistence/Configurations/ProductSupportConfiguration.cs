using ETicaret.Domain.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Infrastructure.Persistence.Configurations;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable("Colors");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
        // HexCode → #FF0000 formatında 7 karakter
        builder.Property(c => c.HexCode).IsRequired().HasMaxLength(7);
        builder.HasQueryFilter(c => !c.IsDeleted);
    }
}

public class SizeConfiguration : IEntityTypeConfiguration<Size>
{
    public void Configure(EntityTypeBuilder<Size> builder)
    {
        builder.ToTable("Sizes");
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Name).IsRequired().HasMaxLength(20);
        builder.HasQueryFilter(s => !s.IsDeleted);
    }
}

public class AttributeTypeConfiguration : IEntityTypeConfiguration<AttributeType>
{
    public void Configure(EntityTypeBuilder<AttributeType> builder)
    {
        builder.ToTable("AttributeTypes");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
        builder.HasQueryFilter(a => !a.IsDeleted);
    }
}

public class AttributeValueConfiguration : IEntityTypeConfiguration<AttributeValue>
{
    public void Configure(EntityTypeBuilder<AttributeValue> builder)
    {
        builder.ToTable("AttributeValues");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Value).IsRequired().HasMaxLength(100);

        builder.HasOne(a => a.AttributeType)
            .WithMany(at => at.AttributeValues)
            .HasForeignKey(a => a.AttributeTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasQueryFilter(a => !a.IsDeleted);
    }
}

public class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
{
    public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
    {
        builder.ToTable("ProductAttributeValues");
        builder.HasKey(pa => pa.Id);

        builder.HasOne(pa => pa.Product)
            .WithMany(p => p.AttributeValues)
            .HasForeignKey(pa => pa.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pa => pa.AttributeValue)
            .WithMany(av => av.ProductAttributeValues)
            .HasForeignKey(pa => pa.AttributeValueId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(pa => !pa.IsDeleted);
    }
}
