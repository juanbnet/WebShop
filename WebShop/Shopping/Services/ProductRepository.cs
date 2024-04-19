using Shopping.Data;
using Shopping.Interfaces;
using Shopping.Models;

namespace Shopping.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly GraphQLDbContext _dbContext;
        public ProductRepository(GraphQLDbContext dbContext)
        {
              _dbContext = dbContext;
        }

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ProductId==id);
        }

        public ICollection<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public bool IsStockAvailable(Product product)
        {
            return _dbContext.Products.Any(p => p.ProductCode== product.ProductCode &&
                                                p.Stock > 0
                                          );
        }

        public bool UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
