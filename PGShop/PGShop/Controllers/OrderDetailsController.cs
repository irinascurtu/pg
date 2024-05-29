using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PGShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
       
        public OrderDetailsController()
        {
            
        }

        // orders/{orderId}/details
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }



    }
}
