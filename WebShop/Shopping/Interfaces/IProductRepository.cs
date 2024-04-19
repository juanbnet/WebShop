using Shopping.Models;

namespace Shopping.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetProducts();
        Product GetProductById(int id);
        bool AddProduct(Product product);
        bool IsStockAvailable(Product product);
        bool UpdateProduct(int id,Product product);
        void DeleteProduct(int id);

    }
}
