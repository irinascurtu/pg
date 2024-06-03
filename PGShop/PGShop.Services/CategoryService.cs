using PGShop.Data;
using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        //CRUD - > passtrough for the repositoriesf

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public bool CheckIfExists(int id)
        {
            return categoryRepository.Exists(id);
        }

        public bool CheckIfExists(string categoryName)
        {
            return categoryRepository.Exists(categoryName);
        }

        public Category GetCategory(int id)
        {
            return categoryRepository.GetById(id);//returns existing object
        }

        public IQueryable<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }

        public Category AddNewCategory(Category category)
        {
            return categoryRepository.AddNewCategory(category);
        }

        public Category Update(Category category)
        {
            return categoryRepository.UpdateCategory(category);
        }

        public bool DeleteCategory(int id)
        {
            var itemToDelete = categoryRepository.GetById(id);
            if (itemToDelete == null)
            {
                throw new Exception("Item was not found");
            }
            var item = categoryRepository.DeleteCategory(itemToDelete);

            return item > 0;
        }
    }
}
