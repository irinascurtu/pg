using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PGShop.Models;
using PGShop.Services;

namespace PGShop.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/categories/{categoryId}/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProductService productService;

        public ProductsController(IMapper mapper, IProductService productService)
        {
            this.mapper = mapper;
            this.productService = productService;
        }


        //categories/{categoryid}/products
        [HttpGet]
        public IActionResult GetAll(int categoryId)
        {
            var products = productService.GetProducts(categoryId);
            var listof= products.ToList();

            var productModels = mapper.Map<List<ProductModel>>(products);

            // include suppliers
            return Ok(productModels);
        }

        //categories/{categoryid}/products/{productId}
        [HttpGet("{id}")]
        public ProductModel GetById(int id)
        {

            return new ProductModel();
        }
    }
}
