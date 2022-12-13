

using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class BreadOrder
    {
        public Guid BreadOrderId { get; set; }
        public BreadType BreadType { get; set; }
        public int Quantity { get; set; }
        public double BreadPrice { get; set; }
        public double TotalBreadOrderPrice { get; set; }
        [ForeignKey("OrderId")]
        public Guid OrderId { get; set; }
        
    }

    public enum BreadType
    {
        Bagguete,
        WhiteBread,
        MilkBread,
        HamburguerBun
    }
}
