using DB;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryFreshBread.Api.Models
{
    public class BreadOrderRequest
    {
        public BreadType BreadType { get; set; }
        public int Quantity { get; set; }
        public double BreadPrice { get; set; }
        public Guid OrderId { get; set; }
    }
}
