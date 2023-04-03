using FluentValidation;

namespace Products.Application.Features.Employes.Commands.CreateEmploye
{
    public class CreateEmployeCommandValidator : AbstractValidator<CreateEmployeCommand>
    {
        public CreateEmployeCommandValidator()
        {
            RuleFor(p => p.FullName).NotEmpty().NotNull().MaximumLength(100);
            
            RuleFor(p => p.Gender).NotEmpty().NotNull();

       
           // RuleFor(x => x.BirthDate).(15);
           // RuleFor(x => x.HireDate).MaximumLength(40);
        
            RuleFor(x => x.Phone).MaximumLength(24);
            RuleFor(x => x.Address).MaximumLength(50);
            RuleFor(x => x.Notes).MaximumLength(115);

          
    }
    }
}
