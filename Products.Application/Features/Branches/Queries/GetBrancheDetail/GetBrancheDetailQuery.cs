using MediatR;
using System;

namespace Products.Application.Features.Branches.Queries.GetBrancheDetail
{
    public class GetBrancheDetailQuery : IRequest<GetBrancheDetailViewModel>
    {
        public Guid BrancheId { get; set; }
    }
}
