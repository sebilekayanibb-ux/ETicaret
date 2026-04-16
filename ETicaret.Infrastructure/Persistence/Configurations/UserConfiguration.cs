using ETicaret.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Infrastructure.Persistence.Configurations;

// IEntityTypeConfiguration<User> → EF Core'a User entity'si için özel ayarlar yapar
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(50);

        // Email benzersiz olmalı, iki kullanıcı aynı email ile kayıt olamaz
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);
        builder.HasIndex(u => u.Email).IsUnique();

        builder.Property(u => u.PhoneNumber)
            .HasMaxLength(15);

        builder.Property(u => u.PasswordHash)
            .IsRequired();

        // Soft delete → IsDeleted = true olan kayıtlar sorgularda otomatik filtrele
        builder.HasQueryFilter(u => !u.IsDeleted);
    }
}
