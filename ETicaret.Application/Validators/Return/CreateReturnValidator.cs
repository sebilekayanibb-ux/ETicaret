using ETicaret.Application.DTOs.Return;
using FluentValidation;

namespace ETicaret.Application.Validators.Return;

public class CreateReturnValidator : AbstractValidator<CreateReturnDto>
{
    public CreateReturnValidator()
    {
        RuleFor(x => x.OrderId)
            .NotEmpty().WithMessage("Sipariş seçilmelidir.");

        RuleFor(x => x.ReturnReason)
            .NotEmpty().WithMessage("İade sebebi boş olamaz.")
            .MaximumLength(500).WithMessage("İade sebebi 500 karakterden uzun olamaz.");

        RuleFor(x => x.RefundMethod)
            .IsInEnum().WithMessage("Geçerli bir iade yöntemi seçilmelidir.");

        // En az 1 ürün iade edilmeli
        RuleFor(x => x.Items)
            .NotEmpty().WithMessage("İade edilecek en az 1 ürün seçilmelidir.");

        // Her iade ürünü için quantity > 0
        RuleForEach(x => x.Items).ChildRules(item =>
        {
            item.RuleFor(x => x.OrderItemId)
                .NotEmpty().WithMessage("Ürün seçilmelidir.");

            item.RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("İade adedi 0'dan büyük olmalıdır.");
        });
    }
}
