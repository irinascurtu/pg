using PGShop.Entities;
using PGShop.Models;

namespace PGShop.Data
{
    public static class Extensions
    {

        public static Category ToCategory(this CategoryModel model)
        {
            Category newCategory = new Category();
            newCategory.Categoryname = model.Categoryname;
            newCategory.Description = model.Description;

            return newCategory;
        }

    }
}
