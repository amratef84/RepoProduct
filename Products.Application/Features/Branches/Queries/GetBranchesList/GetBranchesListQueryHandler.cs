using AutoMapper;
using MediatR;
using Products.Application.Contracts.Persistence;
using Products.Application.Features.Branches.Queries.GetBranchesList;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Branches.Queries.GetBranchesList
{
    public class GetBranchesListQueryHandler : IRequestHandler<GetBranchesListQuery, List<GetBranchesListViewModel>>
    {
        private readonly IBrancheRepository _postRepository;
        private readonly IMapper _mapper;

        public GetBranchesListQueryHandler(IBrancheRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<List<GetBranchesListViewModel>> Handle(GetBranchesListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postRepository.GetAllBrancheAsync();
            return _mapper.Map<List<GetBranchesListViewModel>>(allPosts);
        }
    }
}
