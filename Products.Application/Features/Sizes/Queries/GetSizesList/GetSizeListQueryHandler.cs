using AutoMapper;
using MediatR;
using Products.Application.Contracts.Persistence;
using Products.Application.Features.Sizes.Queries.GetSizesList;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Sizes.Queries.GetSizesList
{
    public class GetSizesListQueryHandler : IRequestHandler<GetSizesListQuery, List<GetSizesListViewModel>>
    {
        private readonly ISizeRepository _postRepository;
        private readonly IMapper _mapper;

        public GetSizesListQueryHandler(ISizeRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<List<GetSizesListViewModel>> Handle(GetSizesListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postRepository.GetAllSizeAsync();
            return _mapper.Map<List<GetSizesListViewModel>>(allPosts);
        }
    }
}
