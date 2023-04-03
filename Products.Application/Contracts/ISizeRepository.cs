using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Domain.Entites;
using Products.Domain.Entities;

namespace Products.Application.Contracts.Persistence
{
    public interface ISizeRepository : IAsyncRepository<Size>
    {
        Task<IReadOnlyList<Size>> GetAllSizeAsync();
        Task<Size> GetSizeByIdAsync(Guid id);
    }
}
