using ETicaret.Domain.Entities.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Infrastructure.Persistence.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.RecipientName).IsRequired().HasMaxLength(100);
        builder.Property(a => a.City).IsRequired().HasMaxLength(50);
        builder.Property(a => a.District).IsRequired().HasMaxLength(50);
        builder.Property(a => a.Neighborhood).IsRequired().HasMaxLength(100);
        builder.Property(a => a.AddressDetail).IsRequired().HasMaxLength(300);
        builder.Property(a => a.AddressTitle).IsRequired().HasMaxLength(50);
        builder.Property(a => a.PhoneNumber).HasMaxLength(15);

        // Bir kullanıcının birden fazla adresi olabilir (1 - N ilişkisi)
        builder.HasOne(a => a.User)
            .WithMany(u => u.Addresses)
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasQueryFilter(a => !a.IsDeleted);
    }
}
