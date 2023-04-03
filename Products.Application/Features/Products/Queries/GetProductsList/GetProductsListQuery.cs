using MediatR;
using System.Collections.Generic;

namespace Products.Application.Features.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : IRequest<List<GetProductsListViewModel>>
    {

    }
}
