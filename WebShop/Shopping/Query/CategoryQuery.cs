using GraphQL.Types;

using Shopping.Interfaces;
using Shopping.Type;

namespace Shopping.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            Field<ListGraphType<CategoryType>>("Categories").Resolve(context =>
            {
                return categoryRepository.GetCategories();
            });

        }
    }
}
