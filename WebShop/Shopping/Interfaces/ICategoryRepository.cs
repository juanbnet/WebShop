using Shopping.Models;

namespace Shopping.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategoryById(int id);
        bool AddCategory(List<Category> categories);        
    }
}
