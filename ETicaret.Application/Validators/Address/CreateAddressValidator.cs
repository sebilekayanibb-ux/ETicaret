using ETicaret.Application.DTOs.Address;
using FluentValidation;

namespace ETicaret.Application.Validators.Address;

public class CreateAddressValidator : AbstractValidator<CreateAddressDto>
{
    public CreateAddressValidator()
    {
        RuleFor(x => x.RecipientName)
            .NotEmpty().WithMessage("Alıcı adı boş olamaz.")
            .MaximumLength(100).WithMessage("Alıcı adı 100 karakterden uzun olamaz.");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("İl boş olamaz.");

        RuleFor(x => x.District)
            .NotEmpty().WithMessage("İlçe boş olamaz.");

        RuleFor(x => x.Neighborhood)
            .NotEmpty().WithMessage("Mahalle boş olamaz.");

        RuleFor(x => x.AddressDetail)
            .NotEmpty().WithMessage("Adres detayı boş olamaz.")
            .MaximumLength(250).WithMessage("Adres detayı 250 karakterden uzun olamaz.");

        RuleFor(x => x.AddressTitle)
            .NotEmpty().WithMessage("Adres başlığı boş olamaz.")
            .MaximumLength(50).WithMessage("Adres başlığı 50 karakterden uzun olamaz.");

        RuleFor(x => x.PhoneNumber)
            .Matches(@"^[0-9]{10,11}$").When(x => !string.IsNullOrEmpty(x.PhoneNumber))
            .WithMessage("Geçerli bir telefon numarası girin.");
    }
}
