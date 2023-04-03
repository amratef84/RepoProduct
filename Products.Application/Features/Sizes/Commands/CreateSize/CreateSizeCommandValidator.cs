using FluentValidation;

namespace Products.Application.Features.Sizes.Commands.CreateSize
{
    public class CreateSizeCommandValidator : AbstractValidator<CreateSizeCommand>
    {
        public CreateSizeCommandValidator()
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
