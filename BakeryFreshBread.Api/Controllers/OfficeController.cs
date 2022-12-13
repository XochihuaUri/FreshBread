using BakeryFreashBread.models.Services;
using BakeryFreshBread.Api.Adapaters;
using BakeryFreshBread.Api.Models;
using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BakeryFreshBread.Api.Controllers
{
    [ApiController]
    [Route("api/offices")]
    public class OfficeController : ControllerBase
    {
        private readonly BakeryFreshBreadContext _context;
        public OfficeController(BakeryFreshBreadContext context)
        {
            _context = context;
        }

        //it returns all the offices in the table offices
        [HttpGet]
        public async Task<IEnumerable<Office>> GetOffices()
        {
            var offices = await _context.Offices.ToListAsync();
            var orders = await _context.Orders.ToListAsync();
            var breadOrders = await _context.BreadOrders.ToListAsync();

            foreach (var office in offices)
            {
                foreach (var order in orders)
                {
                    if (order.OfficeId == office.OfficeId && !office.Orders.Contains(order))
                    {
                        foreach (var breadOrder in breadOrders)
                        {
                            if (breadOrder.OrderId == order.OrderId && !order.BreadOrders.Contains(breadOrder))
                            {

                                order.BreadOrders.Add(breadOrder);
                            }
                        }

                        office.Orders.Add(order);
                    }
                }
            }
            return offices;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Office>> GetOffice(Guid id)
        {
            var offices = await _context.Offices.FindAsync(id);
            if(offices == null)
            {
                return NotFound();
            }
            return offices;
        }

        [HttpPost]
        public async Task<ActionResult<Office>> PostOffice(OfficeRequest office)
        {
            Office office1 = new Office() { 
                OfficeId = Guid.NewGuid(), 
                OfficeType = office.OfficeType 
            };
            _context.Offices.Add(office1);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Getoffices", new {id = office1.OfficeId}, office);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffice(Guid id)
        {
            var office = await _context.Offices.FindAsync(id);
            if(office == null)
            {
                return NotFound();
            }
            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
