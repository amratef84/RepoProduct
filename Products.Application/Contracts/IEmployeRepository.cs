
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Domain.Entites;



namespace Products.Application.Contracts.Persistence
{
    public interface IEmployeRepository : IAsyncRepository<Employe>
    {
        Task<IReadOnlyList<Employe>> GetAllEmployeAsync();
        Task<Employe> GetEmployeByIdAsync(Guid id);
        Task<Employe> CreateEmployeeWithUser(Employe employe);
    }
}

