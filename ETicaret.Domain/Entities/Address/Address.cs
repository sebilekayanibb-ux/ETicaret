using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Address;

public class Address : BaseEntity
{
    public Guid UserId { get; set; }
    public string RecipientName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public string AddressDetail { get; set; } = string.Empty;
    public string AddressTitle { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    // Navigation Properties
    public User.User User { get; set; } = null!;
}
