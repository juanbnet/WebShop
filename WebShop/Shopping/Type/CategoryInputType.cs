using GraphQL.Types;

namespace Shopping.Type
{
    public class CategoryInputType:InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("CategoryId");
            Field<StringGraphType>("CategoryName");
        }

    }
}
