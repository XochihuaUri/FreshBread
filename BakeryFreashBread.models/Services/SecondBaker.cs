using BakeryFreashBread.models.Interfaces;
using BakeryFreashBread.models.Models;

namespace BakeryFreashBread.models.Services
{
    public class SecondBaker : IBaker
    {
        public IOrder Order { get; set; }
        public SecondBaker()
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

        public void CreateHamburguerBunOrder()
        {
            IBreadOrder breadOrder = new BreadOrder(1, new HamburguerBun());
            Order.BreadOrders.Add(breadOrder);
        }
        public void CreateHamburguerBunOrder(int quantity)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new HamburguerBun());
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
