using GraphQL.DI;

using Shopping.Mutation;
using Shopping.Query;

namespace Shopping.Schema
{
    public class RootSchema: GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
