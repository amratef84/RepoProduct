using FluentValidation;

namespace Products.Application.Features.Branches.Commands.CreateBranche
{
    public class CreateBrancheCommandValidator : AbstractValidator<CreateBrancheCommand>
    {
        public CreateBrancheCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            
            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull();

            RuleFor(p => p.Country)
     .NotEmpty()
     .NotNull();
            RuleFor(p => p.City)
     .NotEmpty()
     .NotNull();

        }


    }
}
