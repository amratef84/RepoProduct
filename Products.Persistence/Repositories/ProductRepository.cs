
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext productDbContext): base(productDbContext)
        {

        }
        public async Task<IReadOnlyList<Product>> GetAllProductAsync()
        {
            
            List<Product> allPosts = new List<Product>();
          //  allPosts = includeCategory ? await _dbContext.Products.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            allPosts =  await _dbContext.Products.ToListAsync();
            return allPosts;
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            Product Post = new Product();
            Post =  await GetByIdAsync(id);
            return Post;
        }
    }

}
