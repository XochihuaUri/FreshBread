using DB;

namespace BakeryFreshBread.Api.Models
{
    public class OrderRequestPut
    {
        public Guid OrderId { get; set; }
        public List<BreadOrder> BreadOrders { get; set; } = new List<BreadOrder>();
    }
}
