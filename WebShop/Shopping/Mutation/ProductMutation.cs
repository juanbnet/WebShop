using System.ComponentModel.Design;

using GraphQL;
using GraphQL.Types;

using Shopping.Interfaces;
using Shopping.Models;
using Shopping.Type;

namespace Shopping.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProductRepository productRepository)
        {
            Field<ProductType>("CreateProduct").Arguments(new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" })).Resolve(context =>
            {
                return productRepository.AddProduct(context.GetArgument<Product>("product"));
            });

            Field<ProductType>("UpdateProduct").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "productId" },
                new QueryArgument<ProductInputType> { Name = "product" })).Resolve(context =>
                {
                    var product = context.GetArgument<Product>("product");
                    var productId = context.GetArgument<int>("productId");
                    return productRepository.UpdateProduct(productId, product);
                });

            Field<StringGraphType>("DeleteProduct").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "productId" },
            new QueryArgument<ProductInputType> { Name = "product" })).Resolve(context =>
            {
                var productId = context.GetArgument<int>("productId");
                productRepository.DeleteProduct(productId);
                
                return "The product against this Id" + productId + "has been deleted";
            });

        }
    }
}
