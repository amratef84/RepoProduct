
using GraphQL.Types;
using Products.Domain.Entites;

namespace Products.Api.GraphQL.Types {
    public class SizeType : ObjectGraphType<SizeProduct> {
        public SizeType() {
            Field(f => f.Id, type: typeof(IdGraphType)).Description("Size Id");
         //   Field(f => f.SizeName).Description("Size Title");
     
            Field(f => f.SizePrice, type: typeof(FloatGraphType)).Description("Size Price");
         
            Field(f => f.ProductId, type: typeof(IdGraphType)).Description("Size ProductId");

        }
    }
  
}
