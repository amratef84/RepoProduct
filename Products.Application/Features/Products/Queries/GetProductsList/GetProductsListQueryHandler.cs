using AutoMapper;
using MediatR;
using Products.Application.Contracts.Persistence;
using Products.Application.Features.Products.Queries.GetProductsList;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Products.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<GetProductsListViewModel>>
    {
        private readonly IProductRepository _postRepository;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IProductRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<List<GetProductsListViewModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postRepository.GetAllProductAsync();
            return _mapper.Map<List<GetProductsListViewModel>>(allPosts);
        }
    }
}
