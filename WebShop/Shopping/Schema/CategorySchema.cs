using Shopping.Query;

namespace Shopping.Schema
{
    public class CategorySchema : GraphQL.Types.Schema
    {
        public CategorySchema(CategoryQuery categoryQuery)
        {
            Query = categoryQuery;
        }
    }
}
