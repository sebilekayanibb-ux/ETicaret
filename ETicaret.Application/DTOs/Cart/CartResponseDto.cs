

namespace ETicaret.Application.DTOs.Cart
{
    public class CartResponseDto
    {
        //Sepeti görüntülerken gerekli bilgiler
        public Guid Id { get; set; }
        public List<CartItemResponseDto> Items { get; set; } = new();
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
