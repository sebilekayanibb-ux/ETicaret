using ETicaret.Domain.Common;

namespace ETicaret.Domain.Entities.Cart;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }

    // Navigation Properties
    public User.User User { get; set; } = null!;
    public ICollection<CartItem> CartItems { get; set; } = [];
}
