//using MediatR;
//using Products.Application.Common.Interfaces;
//using Products.Persistence;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Products.Application.System.Commands.SeedSampleData
//{
//    public class SeedSampleDataCommand : IRequest
//    {
//    }

//    public class SeedSampleDataCommandHandler : IRequestHandler<SeedSampleDataCommand>
//    {
//        private readonly INorthwindDbContext _context;
//        private readonly IUserManager _userManager;

//        public SeedSampleDataCommandHandler(IProductsDbContext context, IUserManager userManager)
//        {
//            _context = context;
//            _userManager = userManager;
//        }

//        public async Task<Unit> Handle(SeedSampleDataCommand request, CancellationToken cancellationToken)
//        {
//            var seeder = new SampleDataSeeder(_context, _userManager);

//            await seeder.SeedAllAsync(cancellationToken);

//            return Unit.Value;
//        }
//    }
//}
