using MediatR;
using System.Collections.Generic;

namespace Products.Application.Features.Branches.Queries.GetBranchesList
{
    public class GetBranchesListQuery : IRequest<List<GetBranchesListViewModel>>
    {

    }
}
