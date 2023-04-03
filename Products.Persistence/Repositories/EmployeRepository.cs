
using Products.Application.Contracts.Persistence;
using Products.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Persistence.Repositories
{
    public class EmployeRepository : BaseRepository<Employe>, IEmployeRepository
    {
        public EmployeRepository(ProductDbContext productDbContext) : base(productDbContext)
        {

        }
        public async Task<IReadOnlyList<Employe>> GetAllEmployeAsync()
        {
            List<Employe> allPosts = new List<Employe>();
            //  allPosts = includeCategory ? await _dbContext.Products.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            allPosts = await _dbContext.Employes.ToListAsync();
            return allPosts;
        }

        public async Task<Employe> GetEmployeByIdAsync(Guid id)
        {
            Employe Post = new Employe();
            Post = await GetByIdAsync(id);
            return Post;
        }

        public async Task<Employe> CreateEmployeeWithUser(Employe employe)
        {
            _dbContext.Database.BeginTransaction();
            try
            {

                //  await _dbContext.Employes.AddAsync(new Employe { });

                //  await _dbContext.SaveChanges();
                ///here
                ///
                await _dbContext.Set<Employe>().AddAsync(employe);
                await _dbContext.SaveChangesAsync();
           
                _dbContext.Database.CommitTransaction();

          
            }
            catch (Exception ex)
            {
                _dbContext.Database.RollbackTransaction();
            }


            return employe;

        }
    }

}
