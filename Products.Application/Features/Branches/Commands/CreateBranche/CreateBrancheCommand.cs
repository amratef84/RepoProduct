using MediatR;
using System;

namespace Products.Application.Features.Branches.Commands.CreateBranche
{
    public class CreateBrancheCommand : IRequest<Guid>
    {
   
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }


    }
}
