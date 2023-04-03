using AutoMapper;
using MediatR;
using Products.Application.Contracts.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Employes.Queries.GetEmployesList
{
    public class GetEmployesListQueryHandler : IRequestHandler<GetEmployesListQuery, List<GetEmployesListViewModel>>
    {
        private readonly IEmployeRepository _postRepository;
        private readonly IMapper _mapper;

        public GetEmployesListQueryHandler(IEmployeRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<List<GetEmployesListViewModel>> Handle(GetEmployesListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postRepository.GetAllEmployeAsync();
            return _mapper.Map<List<GetEmployesListViewModel>>(allPosts);
        }
    }
}
