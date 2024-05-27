using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Services
{
    public interface ICategoryService
    {
        Category AddNewCategory(Category category);
        bool CheckIfExists(int id);
        bool CheckIfExists(string categoryName);
        bool DeleteCategory(int id);
        IQueryable<Category> GetAllCategories();
        Category GetCategory(int id);
        Category Update(Category category);
    }
}
