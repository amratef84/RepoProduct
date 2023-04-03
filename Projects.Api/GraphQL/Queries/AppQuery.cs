using Products.Api.GraphQL.Types;
using GraphQL.Types;
using MediatR;
using GraphQL;
using System;
using Products.Application.Features.Products.Queries.GetProductsList;

namespace Products.Api.GraphQL.Queries {
    public class AppQuery : ObjectGraphType {
        public AppQuery(ISender mediator) {
            FieldAsync<ListGraphType<ProductType>>(
                "products",
                resolve: async context => await mediator.Send(new GetProductsListQuery()),
                description: "Get all Product with sizes"
           );

            //FieldAsync<SizeType>(
            //    "sizes",
            //    arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "sizeId" }),
            //    resolve: async context => {
            //        try {
            //            int id = context.GetArgument<int>("sizeId");
            //            return await mediator.Send(new GetSessionQuery(id));
            //        } catch (Exception e) {
            //            throw new ExecutionError(e.Message);
            //        }
            //    });
        }
    }
}
