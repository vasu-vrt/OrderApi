using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Model;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static List<Order> Orders = new List<Order>();

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(Orders);
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] Order order)
        {
            order.Id = Orders.Count + 1;
            Orders.Add(order);
            return Ok(order);
        }
    }

}
