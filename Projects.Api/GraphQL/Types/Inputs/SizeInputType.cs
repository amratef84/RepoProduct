using GraphQL.Types;

namespace Products.Api.GraphQL.Types.Inputs {
    public class SizeInputType : InputObjectGraphType {
        public SizeInputType() {
            Name = "SessionInput";
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<NonNullGraphType<StringGraphType>>("price");
       
            Field<NonNullGraphType<IntGraphType>>("productId");
        }
    }
}