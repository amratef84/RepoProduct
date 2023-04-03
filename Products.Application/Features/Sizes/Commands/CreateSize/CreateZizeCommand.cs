using MediatR;

namespace Products.Application.Features.Sizes.Commands.CreateSize
{
    public class CreateSizeCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
