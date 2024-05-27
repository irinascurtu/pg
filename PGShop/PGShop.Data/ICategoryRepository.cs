using PGShop.Domain.Entities;

namespace PGShop.Data
{
    public interface ICategoryRepository
    {
        Category AddNewCategory(Category category);
        int DeleteCategory(Category category);
        bool Exists(int id);
        bool Exists(string categoryName);
        IQueryable<Category> GetAll();

        Category GetById(int id);
        Category UpdateCategory(Category category);
    }
}