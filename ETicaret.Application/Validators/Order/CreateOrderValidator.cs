using ETicaret.Application.DTOs.Order;
using FluentValidation;

namespace ETicaret.Application.Validators.Order;

public class CreateOrderValidator : AbstractValidator<CreateOrderDto>
{
    public CreateOrderValidator()
    {
        RuleFor(x => x.ShippingAddressId)
            .NotEmpty().WithMessage("Teslimat adresi seçilmelidir.");

        RuleFor(x => x.BillingAddressId)
            .NotEmpty().WithMessage("Fatura adresi seçilmelidir.");

        RuleFor(x => x.PaymentMethod)
            .IsInEnum().WithMessage("Geçerli bir ödeme yöntemi seçilmelidir.");

        RuleFor(x => x.DeliveryType)
            .IsInEnum().WithMessage("Geçerli bir teslimat türü seçilmelidir.");

        RuleFor(x => x.InstallmentCount)
            .GreaterThan(0).WithMessage("Taksit sayısı 0'dan büyük olmalıdır.");
    }
}
