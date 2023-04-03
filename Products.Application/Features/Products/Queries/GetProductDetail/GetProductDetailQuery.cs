using MediatR;
using System;

namespace Products.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<GetProductDetailViewModel>
    {
        public Guid ProductId { get; set; }
    }
}
