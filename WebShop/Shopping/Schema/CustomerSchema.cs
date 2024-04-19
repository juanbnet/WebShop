using Shopping.Query;

namespace Shopping.Schema
{
    public class CustomerSchema: GraphQL.Types.Schema
    {
        public CustomerSchema(CustomerQuery customerQuery)
        {
            Query = customerQuery;
        }
    }
}
