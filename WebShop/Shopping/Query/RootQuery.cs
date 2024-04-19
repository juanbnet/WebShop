using GraphQL.Types;

namespace Shopping.Query
{
    public class RootQuery:ObjectGraphType
    {
        public RootQuery()
        {
            Field<CustomerQuery>("customerQuery").Resolve(context => new { });
            Field<CategoryQuery>("categoryQuery").Resolve(context => new { });
            Field<ProductQuery>("productQuery").Resolve(context => new { });
        }

    }
}
