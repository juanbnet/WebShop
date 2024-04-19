using GraphQL.Types;

using Shopping.Query;

namespace Shopping.Mutation
{
    public class RootMutation: ObjectGraphType
    {
        public RootMutation()
        {
            Field<ProductMutation>("productMutation").Resolve(context => new { });
        }
    }
}
