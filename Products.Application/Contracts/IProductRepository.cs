using Products.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Application.Contracts.Persistence
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<IReadOnlyList<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(Guid id);
    }
}
