using AutoMapper;
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Employes.Commands.CreateEmploye
{
    public class CreateEmployeCommandHandler : IRequestHandler<CreateEmployeCommand, Guid>
    {
        private readonly IEmployeRepository _postRepository;
        private readonly IMapper _mapper;

        public CreateEmployeCommandHandler(IEmployeRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateEmployeCommand request, CancellationToken cancellationToken)
        {
            Employe post = _mapper.Map<Employe>(request);

            CreateEmployeCommandValidator validator = new CreateEmployeCommandValidator();
            var result = await validator.ValidateAsync(request);

          

            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid");
            }

            post = await _postRepository.CreateEmployeeWithUser(post);

            return post.Id;
        }
    }
}
