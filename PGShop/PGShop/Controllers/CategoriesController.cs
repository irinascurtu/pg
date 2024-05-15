using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
