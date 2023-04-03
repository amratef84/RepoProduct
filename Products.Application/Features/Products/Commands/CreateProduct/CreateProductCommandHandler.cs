using AutoMapper;
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _postRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product post = _mapper.Map<Product>(request);

            CreateProductCommandValidator validator = new CreateProductCommandValidator();
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
