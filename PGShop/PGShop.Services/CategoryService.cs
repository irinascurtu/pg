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

        public Category GetCategory(int id)
        {
            return categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }
    }
}
