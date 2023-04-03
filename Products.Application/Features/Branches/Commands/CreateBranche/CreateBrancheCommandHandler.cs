using AutoMapper;
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Branches.Commands.CreateBranche
{
    public class CreateBrancheCommandHandler : IRequestHandler<CreateBrancheCommand, Guid>
    {
        private readonly IBrancheRepository _postRepository;
        private readonly IMapper _mapper;

        public CreateBrancheCommandHandler(IBrancheRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateBrancheCommand request, CancellationToken cancellationToken)
        {
            Branche post = _mapper.Map<Branche>(request);

            CreateBrancheCommandValidator validator = new CreateBrancheCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid");
            }

            post = await _postRepository.AddAsync(post);

            return post.Id;
        }
    }
}
