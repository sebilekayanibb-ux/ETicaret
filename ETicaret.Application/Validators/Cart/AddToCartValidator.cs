using ETicaret.Application.DTOs.Cart;
using FluentValidation;

namespace ETicaret.Application.Validators.Cart;

public class AddToCartValidator : AbstractValidator<AddToCartDto>
{
    public AddToCartValidator()
    {
        // Guid boş gelirse (00000000-...) geçersiz sayılır
        RuleFor(x => x.ProductVariantId)
            .NotEmpty().WithMessage("Ürün varyantı seçilmelidir.");

        // Domain kuralıyla aynı — ama burada 400 döner, domain'e ulaşmaz
        RuleFor(x => x.Quantity)
            .GreaterThan(0).WithMessage("Adet 0'dan büyük olmalıdır.");
    }
}
