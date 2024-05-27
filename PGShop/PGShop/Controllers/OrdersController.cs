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
