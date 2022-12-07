

namespace BakeryFreashBread.models.Interfaces
{
    public interface IOrder
    {
        List<IBreadOrder> BreadOrders { get; set; }
        public double CalculateTotalPrice();
    }
}
