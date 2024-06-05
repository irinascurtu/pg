using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGShop.Data;
using PGShop.Domain.Entities;
using PGShop.Models;
using PGShop.Services;

namespace PGShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
            //this.categoryService = new CategoryService(new CategoryRepository(new St))
        }


        [HttpGet]
        public ActionResult<List<CategoryModel>> GetCategories([FromQuery] CategoryFilter model)
        {
            // var categories = context.Categories.ToList();
            //  var categories = categoryService.GetAllCategories().ToList();
            var categories = categoryService.GetAllCategories();

            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                {
                    categories = categories.Where(x => x.Categoryname.StartsWith(model.Name));
                }

                if (!string.IsNullOrEmpty(model.Description))
                {
                    categories = categories.Where(x => x.Description.ToLower().Contains(model.Description.ToLower()));
                }

            }


            //IEnumerable vs IQueryable
            List<CategoryModel> result = mapper.Map<List<CategoryModel>>(categories);



            //List<CategoryModel> result = new List<CategoryModel>();
            //foreach (var category in categories)
            //{
            //    var item = new CategoryModel();
            //    item.Description = category.Description;
            //    item.Categoryname = category.Categoryname;
            //    item.Categoryid = category.Categoryid;
            //    result.Add(item);
            //}

            //context.Categories.FromSql<Category>($"select * from Categories");
            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryModel> GetCategory(int id)
        {
            //var category = context.Categories.FirstOrDefault(x => x.Categoryid == id);
            var category = categoryService.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }

            //Category(comes from the db .Entities Folder) -> CategoryModel(the actual model)
            //var model = new CategoryModel();
            //model.Description = category.Description;
            //model.Categoryid = category.Categoryid;
            //model.Categoryname = category.Categoryname;
            var model = mapper.Map<CategoryModel>(category);

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

            var existing = categoryService.CheckIfExists(model.Categoryname);
            if (existing)
            {
                ModelState.AddModelError("Categoryname", "There is already an item with same category name.");
                return Conflict(ModelState);
            }

            var newCategory = mapper.Map<Category>(model);
            categoryService.AddNewCategory(newCategory);


            //Category- >CategoryModel
            var addedEntity = mapper.Map<CategoryModel>(newCategory);

            return CreatedAtAction(nameof(GetCategory), new { id = addedEntity.Categoryid }, addedEntity);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, CategoryModel model)
        {
            if (id != model.Categoryid)
            {
                return BadRequest();
            }

            // var itemFromDb = context.Categories.Find(id);
            var itemFromDb = categoryService.GetCategory(id);
            if (itemFromDb == null)
            {
                return NotFound();
            }

            itemFromDb.Description = model.Description;
            itemFromDb.Categoryname = model.Categoryname;

            //var updatedEntity = context.Categories.Update(itemFromDb).Entity;
            //context.SaveChanges();
            var updatedEntity = categoryService.Update(itemFromDb);

            return Ok(model);

        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //var existingItem = context.Categories.Find(id);

            //if (existingItem == null)
            //{
            //    return NotFound();
            //}

            //var deletedItem = context.Categories.Remove(existingItem);
            //context.SaveChanges();
            categoryService.DeleteCategory(id);

            return NoContent();//204
        }

        [HttpHead("{id}")]
        public ActionResult CheckIfExists(int id)
        {
            //var existingCategory = context.Categories.Find(id);

            var existingCategory = categoryService.CheckIfExists(id);
            if (!existingCategory)
            {
                return NotFound();
            }

            return Ok(existingCategory);
        }
    }
}
