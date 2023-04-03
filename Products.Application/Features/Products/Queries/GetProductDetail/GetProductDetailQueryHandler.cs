using AutoMapper;
using Products.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailViewModel>
    {
        private readonly IProductRepository _postRepository;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(IProductRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<GetProductDetailViewModel> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var Post = await _postRepository.GetProductByIdAsync(request.ProductId);

            return _mapper.Map<GetProductDetailViewModel>(Post);
        }
    }
}
