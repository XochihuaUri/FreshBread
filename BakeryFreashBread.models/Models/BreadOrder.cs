

using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Models
{
    public class BreadOrder : IBreadOrder
    {
        public int Quantity { get; set; }
        public double OrderPrice { get; set; }
        public IBread Bread{ get; set; }
        public BreadOrder(int quantity, IBread bread)
        {
            Quantity = quantity;
            OrderPrice = quantity * bread.Price;
            Bread = bread;
        }
    }
}
