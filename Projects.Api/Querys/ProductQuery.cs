//using Microsoft.EntityFrameworkCore;
//using Products.Domain.Entites;
//using Products.Persistence;

//namespace Products.Querys
//{
//    public class ProductQuery
//    {
//        [UseProjection]
//        [UseFiltering]
//        [UseSorting]
//        public List<Product> GetProducts([Service] ProductDbContext _context)
//        {
//            return _context.Products.ToList();
//        }       

//    }
//}
