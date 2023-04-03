using Products.Api.GraphQL.Queries;
using GraphQL.Types;
using GraphQL.Utilities;
using System;
using Schema = GraphQL.Types.Schema;

namespace Products.Api.GraphQL.Schemas {
    public class AppSchema : Schema {
        public AppSchema(IServiceProvider provider) : base(provider) {
            Query = provider.GetRequiredService<AppQuery>();
            Mutation = provider.GetRequiredService<AppMutation>();
        }
    }
}
