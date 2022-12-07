using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Models
{
    public class Order : IOrder
    {
        public List<IBreadOrder> BreadOrders { get; set; }

        public Order()
        {
            BreadOrders = new List<IBreadOrder>();
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (IBreadOrder item in BreadOrders)
            {
                totalPrice+= item.OrderPrice;
            }
            return totalPrice;
        }
    }
}
