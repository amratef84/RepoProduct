using MediatR;
using System;

namespace Products.Application.Features.Employes.Queries.GetEmployeDetail
{
    public class GetEmployeDetailQuery : IRequest<GetEmployeDetailViewModel>
    {
        public Guid EmployeId { get; set; }
    }
}
