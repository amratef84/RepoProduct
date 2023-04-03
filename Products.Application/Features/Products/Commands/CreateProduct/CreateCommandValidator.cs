using FluentValidation;

namespace Products.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            
            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull();
        }
    }
}
