using Microsoft.EntityFrameworkCore;
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;

namespace Products.Persistence.Repositories
{
  
    public class BrancheRepository : BaseRepository<Branche>, IBrancheRepository
    {
        public BrancheRepository(ProductDbContext productDbContext) : base(productDbContext)
        {

        }
        public async Task<IReadOnlyList<Branche>> GetAllBrancheAsync()
        {
            List<Branche> allPosts = new List<Branche>();
            //  allPosts = includeCategory ? await _dbContext.Products.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
           allPosts = await _dbContext.Branches.ToListAsync();
            return allPosts;
        }

        public async Task<Branche> GetBrancheByIdAsync(Guid id)
        {
            Branche Post = new Branche();
            Post = await GetByIdAsync(id);
            return Post;
        }
    }

}
