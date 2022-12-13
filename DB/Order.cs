using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public double TotalOrderPrice { get; set; }
        public virtual ICollection<BreadOrder> BreadOrders { get; set; } = new List<BreadOrder>();
        [ForeignKey("OfficeId")]
        public Guid OfficeId { get; set; }
        
    }
}
