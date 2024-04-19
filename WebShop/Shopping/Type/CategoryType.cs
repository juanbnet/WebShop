using GraphQL.Types;

using Shopping.Models;

namespace Shopping.Type
{
    public class CategoryType: ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(c => c.CategoryName);                        
        }

    }
}
