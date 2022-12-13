using DB;
using Microsoft.EntityFrameworkCore;

namespace BakeryFreshBread.Api.Repositories
{
    public class OfficeRepository
    {
        private readonly BakeryFreshBreadContext _context;
        public OfficeRepository(BakeryFreshBreadContext context)
        {
            _context = context;
        }

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
    }
}
