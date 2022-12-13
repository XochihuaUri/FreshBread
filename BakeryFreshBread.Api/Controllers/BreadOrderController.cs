using BakeryFreshBread.Api.Models;
using BakeryFreshBread.Api.Services;
using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BakeryFreshBread.Api.Controllers
{

    [ApiController]
    [Route("api/breadOrder")]
    public class BreadOrderController : ControllerBase
    {
        private readonly BakeryFreshBreadContext _context;

        public BreadOrderController(BakeryFreshBreadContext context)
        {
            _context = context;
        }

        //it returns all the offices in the table offices
        [HttpGet]
        public async Task<IEnumerable<BreadOrder>> GetBreadOrders()
        {
            return await _context.BreadOrders.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BreadOrder>> GetBreadOrder(Guid id)
        {
            var breadOrders = await _context.BreadOrders.FindAsync(id);
            if (breadOrders == null)
            {
                return NotFound();
            }
            return breadOrders;
        }

        [HttpPost]
        public async Task<ActionResult<BreadOrder>> PostBreadOrder(BreadOrderRequest breadOrderRequest)
        {
            var order = await _context.Orders.FindAsync(breadOrderRequest.OrderId);
            if (order == null)
            {
                throw new Exception("Order not found");
            }

            BreadOrder breadOrder = new BreadOrder()
            {
                BreadOrderId = Guid.NewGuid(),
                OrderId = order.OrderId,
                BreadType = breadOrderRequest.BreadType,
                BreadPrice = breadOrderRequest.BreadPrice,
                Quantity = breadOrderRequest.Quantity,
                TotalBreadOrderPrice = BreadOrderService.GetTotalOrderBreadPrice(breadOrderRequest),
            };
            _context.BreadOrders.Add(breadOrder);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetBreadOrders", new { id = breadOrder.OrderId }, breadOrder);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreadOrder(Guid id)
        {
            var breadOrder = await _context.BreadOrders.FindAsync(id);
            if (breadOrder == null)
            {
                return NotFound();
            }
            _context.BreadOrders.Remove(breadOrder);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
