using System;

namespace Products.Application.Features.Sizes.Queries.GetSizesList
{
    public class GetSizesListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //    public CategoryDto Category { get; set; }
        //  public ICollection<Size> Sizes { get; set; }
    }
}
