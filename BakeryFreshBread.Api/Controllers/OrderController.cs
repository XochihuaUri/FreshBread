using BakeryFreshBread.Api.Models;
using BakeryFreshBread.Api.Services;
using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BakeryFreshBread.Api.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly BakeryFreshBreadContext _context;

        public OrderController(BakeryFreshBreadContext context)
        {
            _context = context;
        }

        //it returns all the offices in the table offices
        [HttpGet]
        public async Task<IEnumerable<Order>> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            var breadOrders = await _context.BreadOrders.ToListAsync();

            foreach (var order in orders)
            {
                foreach (var breadOrder in breadOrders)
                {
                    if(breadOrder.OrderId == order.OrderId && !order.BreadOrders.Contains(breadOrder))
                    {
                        BreadOrder a = breadOrder;

                        order.BreadOrders.Add(breadOrder);
                    }
                }
            }
            return  orders;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            return orders;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderRequestPost orderRequest)
        {
            var office = await _context.Offices.FindAsync(orderRequest.OfficeId);
            if(office == null)
            {
                throw new Exception("Office not found");
            }

            Order order = new Order()
            {
                OrderId = Guid.NewGuid(),
                TotalOrderPrice = 0,
                OfficeId = office.OfficeId,
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOrders", new { id = order.OrderId }, order);
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
