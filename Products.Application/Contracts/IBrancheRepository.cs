using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Domain.Entites;



namespace Products.Application.Contracts.Persistence
{
    public interface IBrancheRepository : IAsyncRepository<Branche>
    {
        Task<IReadOnlyList<Branche>> GetAllBrancheAsync();
        Task<Branche> GetBrancheByIdAsync(Guid id);
    }
}
