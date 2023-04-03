using AutoMapper;
using Products.Application.Features.Branches.Commands.CreateBranche;
using Products.Application.Features.Branches.Queries.GetBrancheDetail;
using Products.Application.Features.Branches.Queries.GetBranchesList;
using Products.Application.Features.Employes.Commands.CreateEmploye;
using Products.Application.Features.Employes.Queries.GetEmployeDetail;
using Products.Application.Features.Employes.Queries.GetEmployesList;
using Products.Application.Features.Products.Commands.CreateProduct;
using Products.Application.Features.Products.Queries.GetProductDetail;
using Products.Application.Features.Products.Queries.GetProductsList;
using Products.Domain.Entites;

namespace Products.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductsListViewModel>().ReverseMap();
            CreateMap<Product, GetProductDetailViewModel>().ReverseMap();
         //   CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();


            CreateMap<Employe, GetEmployesListViewModel>().ReverseMap();
            CreateMap<Employe, GetEmployeDetailViewModel>().ReverseMap();
            CreateMap<Employe, CreateEmployeCommand>().ReverseMap();


            CreateMap<Branche, GetBranchesListViewModel>().ReverseMap();
            CreateMap<Branche, GetBrancheDetailViewModel>().ReverseMap();
            CreateMap<Branche, CreateBrancheCommand>().ReverseMap();


        }
    }
}
