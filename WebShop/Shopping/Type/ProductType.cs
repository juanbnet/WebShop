using GraphQL.Types;

using Shopping.Models;

namespace Shopping.Type
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.ProductName);
            Field(p => p.ProductCode);
            Field(p => p.ProductDescription);            
            Field(p => p.Price);
            Field(p => p.Stock); 
        }
    }
}
