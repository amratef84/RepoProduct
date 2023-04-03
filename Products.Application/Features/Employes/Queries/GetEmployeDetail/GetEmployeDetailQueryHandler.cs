using AutoMapper;
using Products.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Employes.Queries.GetEmployeDetail
{
    public class GetEmployeDetailQueryHandler : IRequestHandler<GetEmployeDetailQuery, GetEmployeDetailViewModel>
    {
        private readonly IEmployeRepository _postRepository;
        private readonly IMapper _mapper;

        public GetEmployeDetailQueryHandler(IEmployeRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<GetEmployeDetailViewModel> Handle(GetEmployeDetailQuery request, CancellationToken cancellationToken)
        {
            var Post = await _postRepository.GetEmployeByIdAsync(request.EmployeId);

            return _mapper.Map<GetEmployeDetailViewModel>(Post);
        }
    }
}
