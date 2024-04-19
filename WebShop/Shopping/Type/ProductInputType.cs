using GraphQL.Types;

namespace Shopping.Type
{
    public class ProductInputType : InputObjectGraphType
    {
        public ProductInputType()
        {
            Field<IntGraphType>("ProductId");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Code");
            Field<StringGraphType>("Description");
            Field<FloatGraphType>("Price");
            Field<IntGraphType>("Stock");
        }

    }
}
