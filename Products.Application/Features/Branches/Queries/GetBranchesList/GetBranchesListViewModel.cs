using System;

namespace Products.Application.Features.Branches.Queries.GetBranchesList
{
    public class GetBranchesListViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public string? Region { get; set; }

        public string? PostalCode { get; set; }

      //  public ICollection<Employe> Employes { get; private set; }

    }
}
