using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ECommerceAPI.Application.Validators.Products;

public class CreateProductValidator : AbstractValidator<VM_Create_Product>
{
    public CreateProductValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Please add product name !!")
            .MaximumLength(150)
            .WithMessage("Maximum Characters of Product Name is 150");
        RuleFor(p => p.Stock)
            .NotEmpty()
            .NotNull()
            .WithMessage("Please add Stock Information");
    }
}