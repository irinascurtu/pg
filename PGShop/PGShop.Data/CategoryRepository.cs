using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext context;

        public CategoryRepository(StoreContext context)
        {
            this.context = context;
        }

        ///CRUD

        public IEnumerable<Category> GetAll()
        {
            return this.context.Categories;
        }

        public Category GetById(int id)
        {
            return context.Categories.FirstOrDefault(x => x.Categoryid == id);
        }


        public bool Exists(int id)
        {
            return context.Categories.Any(x => x.Categoryid == id);
        }
    }
}

