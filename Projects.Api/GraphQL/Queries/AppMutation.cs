
using Products.Api.GraphQL.Types;
using Products.Api.GraphQL.Types.Inputs;
using GraphQL;
using GraphQL.Types;
using MediatR;
using System;

namespace Products.Api.GraphQL.Queries {
    public class AppMutation : ObjectGraphType {
        public AppMutation(ISender mediator) {
         
        }
    }
}
