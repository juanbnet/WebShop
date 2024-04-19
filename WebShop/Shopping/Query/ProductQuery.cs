using GraphQL;
using GraphQL.Types;

using Shopping.Interfaces;
using Shopping.Type;

namespace Shopping.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("Products").Resolve(context =>
            {
                return productRepository.GetProducts();
            });

            Field<ProductType>("Product").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "productId" })).Resolve(context =>
            {
                return productRepository.GetProductById(context.GetArgument<int>("productId"));
            });

        }
    }
}
