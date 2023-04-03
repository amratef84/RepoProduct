using Microsoft.EntityFrameworkCore;
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;
using Products.Domain.Entities;

namespace Products.Persistence.Repositories
{

    public class SizeRepository : BaseRepository<Size>, ISizeRepository
    {
        public SizeRepository(ProductDbContext productDbContext) : base(productDbContext)
        {

        }
        public async Task<IReadOnlyList<Size>> GetAllSizeAsync()
        {
            List<Size> allPosts = new List<Size>();
            //  allPosts = includeCategory ? await _dbContext.Products.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            allPosts = await _dbContext.Sizes.ToListAsync();
            return allPosts;
        }

        public async Task<Size> GetSizeByIdAsync(Guid id)
        {
            Size Post = new Size();
            Post = await GetByIdAsync(id);
            return Post;
        }
    }

}
