using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PGShop.Models;

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

        public OrdersController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<OrderModel>> GetAll()
        {
            return new List<OrderModel>();
        }


        [HttpGet]
        public ActionResult<OrderModel> GetById()
        {
            return new OrderModel();
        }
    }
}
