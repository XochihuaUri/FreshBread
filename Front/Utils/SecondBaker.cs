using BakeryFreashBread.models.Interfaces;
using BakeryFreashBread.models.Models;
using Front.Models;
using Front.Requests;
using Front.Responses;
using Front.Services;
using Newtonsoft.Json.Linq;

namespace BakeryFreashBread.models.Services
{
    public class SecondBaker : IBaker
    {
        public List<IBreadOrder> BreadOrders { get; set; }

        public SecondBaker()
        {
            BreadOrders = new List<IBreadOrder>();
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (IBreadOrder item in BreadOrders)
            {
                totalPrice += item.OrderPrice;
            }
            return totalPrice;
        }

        public void CreateBaguetteOrder(int quantity = 1)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new Baguette(), BreadType.Bagguete);
            BreadOrders.Add(breadOrder);
        }

        public void CreateWhiteBreadOrder(int quantity = 1)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new WhiteBread(), BreadType.WhiteBread);
            BreadOrders.Add(breadOrder);
        }

        public void CreateEspecialityOfTheOffice(int quantity = 1)
        {
            IBreadOrder breadOrder = new BreadOrder(quantity, new HamburguerBun(), BreadType.HamburguerBun);
            BreadOrders.Add(breadOrder);
        }

        public async Task PrepareAllOrdersAsync(string officeId)
        {
            if (BreadOrders.Count == 0)
            {
                Console.WriteLine("There are no orders to dispatch");
                return;
            }
            OrderResponse order = await OrderActions.CreateOrder(officeId);

            foreach (var breadOrder in BreadOrders)
            {
                breadOrder.Bread.Prepare(breadOrder.Quantity);
                BreadOrderResponse breadOrderResponse = await BreadOrderActions.CreateBreadOrder(order.OrderId, breadOrder);
                Console.WriteLine($"Bread: {Enum.GetName(typeof(BreadType), breadOrder.BreadType)} created");

            }

            Console.WriteLine($"Total cost: {CalculateTotalPrice()}");
            BreadOrders.Clear();
        }
    }
}
