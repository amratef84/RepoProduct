using AutoMapper;
using Products.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Branches.Queries.GetBrancheDetail
{
    public class GetBrancheDetailQueryHandler : IRequestHandler<GetBrancheDetailQuery, GetBrancheDetailViewModel>
    {
        private readonly IBrancheRepository _postRepository;
        private readonly IMapper _mapper;

        public GetBrancheDetailQueryHandler(IBrancheRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<GetBrancheDetailViewModel> Handle(GetBrancheDetailQuery request, CancellationToken cancellationToken)
        {
            var Post = await _postRepository.GetBrancheByIdAsync(request.BrancheId);

            return _mapper.Map<GetBrancheDetailViewModel>(Post);
        }
    }
}
