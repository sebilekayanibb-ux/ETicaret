using ETicaret.Application.DTOs.Product;
using FluentValidation;

namespace ETicaret.Application.Validators.Product;

public class CreateProductValidator : AbstractValidator<CreateProductDto>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ürün adı boş olamaz.")
            .MaximumLength(200).WithMessage("Ürün adı 200 karakterden uzun olamaz.");

        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("Kategori seçilmelidir.");

        RuleFor(x => x.BrandId)
            .NotEmpty().WithMessage("Marka seçilmelidir.");

        RuleFor(x => x.ListPrice)
            .GreaterThan(0).WithMessage("Liste fiyatı 0'dan büyük olmalıdır.");

        RuleFor(x => x.SalePrice)
            .GreaterThan(0).WithMessage("Satış fiyatı 0'dan büyük olmalıdır.")
            .LessThanOrEqualTo(x => x.ListPrice).WithMessage("Satış fiyatı liste fiyatından yüksek olamaz.");
    }
}
