using ETicaret.Domain.Common;
using ETicaret.Domain.Enums;

namespace ETicaret.Domain.Entities.User;

public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Customer;

    // Navigation Properties
    public ICollection<Address.Address> Addresses { get; set; } = [];
    public Cart.Cart? Cart { get; set; }
    public ICollection<Order.Order> Orders { get; set; } = [];
}
