using MediatR;
using System.Collections.Generic;

namespace Products.Application.Features.Sizes.Queries.GetSizesList
{
    public class GetSizesListQuery : IRequest<List<GetSizesListViewModel>>
    {

    }
}
