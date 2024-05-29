using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PGShop.Models;
using PGShop.Services;

namespace PGShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        //1. create a service + interface
        //2. create a repository+ Interface
        //3. register them
        //4. use them inside the constroller
        //5. create a mapping for the model
        //6. implement the two actions inside this controller


        private readonly IMapper mapper;
        private readonly IOrdersService ordersService;

        public OrdersController(IMapper mapper, IOrdersService ordersService)
        {
            this.mapper = mapper;
            this.ordersService = ordersService;
        }

        [HttpGet]
        public ActionResult<List<OrderModel>> GetAll()
        {
            var orders = ordersService.GetAll();

            var models = mapper.Map<List<OrderModel>>(orders);

            return Ok(models);
        }


        [HttpGet("{id}")]
        public ActionResult<OrderModel> GetById(int id)
        {
            return new OrderModel();
        }
    }
}
