using MediatR;
using System;

namespace Products.Application.Features.Employes.Commands.CreateEmploye
{
    public class CreateEmployeCommand : IRequest<Guid>
    {

 
      //  public string? UserId { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }

        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }

        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Notes { get; set; }

        //public CreateUserDto User { get; set; }
    }
}
