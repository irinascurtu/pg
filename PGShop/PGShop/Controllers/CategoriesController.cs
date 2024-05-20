using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PGShop.Data;
using PGShop.Entities;
using PGShop.Models;

namespace PGShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly StoreContext context;

        public CategoriesController(StoreContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<List<Category>> GetCategories()
        {
            var categories = context.Categories.ToList();

            return categories;
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryModel> GetCategory(int id)
        {
            var category = context.Categories.FirstOrDefault(x => x.Categoryid == id);
            if (category == null)
            {
                return NotFound();
            }

            //Category(comes from the db .Entities Folder) -> CategoryModel(the actual model)
            var model = new CategoryModel();
            model.Description = category.Description;
            model.Categoryid = category.Categoryid;
            model.Categoryname = category.Categoryname;

            return Ok(model);
        }


        [HttpPost]
        public ActionResult<CategoryModel> Create(CategoryModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // we don't have a similar item in the database ->Business rule

            var existing = context.Categories.Where(x => x.Categoryname.Equals(model.Categoryname))
                                             .Any();

            if (existing)
            {
                ModelState.AddModelError("Categoryname", "There is already an item with same category name.");
                return Conflict(ModelState);
            }

            //CategoryModel -> Category
            //Category newCategory = new Category();
            //newCategory.Categoryname = model.Categoryname;
            //newCategory.Description = model.Description;
            //Use an Extension Method 
            //use a library like Automapper

            var newCategory = model.ToCategory(); //Sweets
            context.Categories.Add(newCategory);
            context.SaveChanges();


            return CreatedAtAction(nameof(GetCategory), new { id = newCategory.Categoryid }, null);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, CategoryModel model)
        {
            if (id != model.Categoryid)
            {
                return BadRequest();
            }

            var itemFromDb = context.Categories.Find(id);
            if (itemFromDb == null)
            {
                return NotFound();
            }



            itemFromDb.Description = model.Description;
            itemFromDb.Categoryname = model.Categoryname;

            var updatedEntity = context.Categories.Update(itemFromDb).Entity;

            context.SaveChanges();
            return Ok(model);

        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingItem = context.Categories.Find(id);
            if (existingItem == null)
            {
                return NotFound();
            }

            var deletedItem = context.Categories.Remove(existingItem);
            context.SaveChanges();

            return NoContent();//204
        }

        [HttpHead("{id}")]
        public ActionResult CheckIfExists(int id)
        {
            var existingCategory = context.Categories.Find(id);
            if (existingCategory == null)
            {
                return NotFound();
            }

            return Ok(existingCategory);
        }
    }
}
