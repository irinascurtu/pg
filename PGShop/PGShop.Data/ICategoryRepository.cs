using PGShop.Domain.Entities;

namespace PGShop.Data
{
    public interface ICategoryRepository
    {
        bool Exists(int id);
        IEnumerable<Category> GetAll();

        Category GetById(int id);
        
    }
}