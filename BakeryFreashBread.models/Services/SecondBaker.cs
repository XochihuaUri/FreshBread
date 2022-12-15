using BakeryFreashBread.models.Interfaces;
using BakeryFreashBread.models.Models;

namespace BakeryFreashBread.models.Services
{
    public class SecondBaker : IBaker
    {
        public Order Order { get; set; }
        public SecondBaker()
        {
            Order = new Order();
        }

        public void CreateBaguetteOrder(int quantity = 1)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new Baguette());
            Order.BreadOrders.Add(breadOrder);
        }

        public void CreateWhiteBreadOrder(int quantity = 1)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new WhiteBread());
            Order.BreadOrders.Add(breadOrder);
        }

        public void CreateHamburguerBunOrder(int quantity = 1)
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

        public void PrepareAllOrders()
        {
            if (Order.BreadOrders.Count == 0)
            {
                Console.WriteLine("There are no orders to dispatch");
                return;
            }
            foreach (var breadOrder in Order.BreadOrders)
            {
                breadOrder.Bread.Prepare(breadOrder.Quantity);
            }

            Console.WriteLine($"Total cost: {GetOrderPrice()}");
        }
    }
}
