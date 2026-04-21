
namespace ETicaret.Application.DTOs.Cart
{
    public class AddToCartDto
    {
        // Sepete ekleme işlemleri için gerekli bilgiler
        public Guid ProductVariantId { get; set; }
        public int Quantity { get; set; }

    }
}
