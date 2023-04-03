using GraphQL.Types;

namespace Products.Api.GraphQL.Types.Inputs {
    public class ProductInputType : InputObjectGraphType {
        public ProductInputType() {
            Name = "ProductInput";
            Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}
