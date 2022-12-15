using BakeryFreashBread.models.Models;

namespace BakeryFreashBread.models.Interfaces
{
    public interface IBaker
    {
        Order Order { get; }
        public void ClearTheOrder();
        public double GetOrderPrice();
        public void PrepareAllOrders();
    }
}
