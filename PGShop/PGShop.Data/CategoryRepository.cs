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

        public IQueryable<Category> GetAll()
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

        public bool Exists(string categoryName)
        {
            return context.Categories.Where(x => x.Categoryname.Equals(categoryName))
                                           .Any();
        }


        public Category AddNewCategory(Category category)
        {
            var addItem = context.Categories.Add(category);
            context.SaveChanges();
            return addItem.Entity;
        }

        public Category UpdateCategory(Category category)
        {
            var updated = context.Categories.Update(category);
            context.SaveChanges();
            return updated.Entity;
        }


        public int DeleteCategory(Category category)
        {
            var deletedItem = context.Categories.Remove(category);
            return context.SaveChanges();
        }
    }
}

