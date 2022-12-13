using BakeryFreashBread.models.Interfaces;
using BakeryFreashBread.models.Models;

namespace BakeryFreashBread.models.Services
{
    public class MainBaker : IBaker
    {
        public Order Order { get; set; }
        public MainBaker()
        {
            Order = new Order();
        }

        public void CreateBaguetteOrder()
        {
            IBreadOrder breadOrder = new BreadOrder(1, new Baguette());
            Order.BreadOrders.Add(breadOrder);
        }
        public void CreateBaguetteOrder(int quantity)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new Baguette());
            Order.BreadOrders.Add(breadOrder);
        }

        public void CreateWhiteBreadOrder()
        {
            IBreadOrder breadOrder = new BreadOrder(1, new WhiteBread());
            Order.BreadOrders.Add(breadOrder);
        }
        public void CreateWhiteBreadOrder(int quantity)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new WhiteBread());
            Order.BreadOrders.Add(breadOrder);
        }

        public void CreateMilkBreadOrder()
        {
            IBreadOrder breadOrder = new BreadOrder(1, new MilkBread());
            Order.BreadOrders.Add(breadOrder);
        }
        public void CreateMilkBreadOrder(int quantity)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new MilkBread());
            Order.BreadOrders.Add(breadOrder);
        }
        public void ClearTheOrder()
        {
            Order.BreadOrders.Clear();
        }
        public double GetOrderPrice()
        {
            return Order.CalculateTotalPrice();
        }
    }
}
