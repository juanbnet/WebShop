using Shopping.Data;
using Shopping.Interfaces;
using Shopping.Models;

namespace Shopping.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GraphQLDbContext _dbContext;

        public CategoryRepository(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AddCategory(List<Category> categories)
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
