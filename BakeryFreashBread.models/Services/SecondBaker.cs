using BakeryFreashBread.models.Interfaces;
using BakeryFreashBread.models.Models;

namespace BakeryFreashBread.models.Services
{
    public class SecondBaker 
    {
        //public List<IBreadOrder> BreadOrders { get; set; }

        //public SecondBaker()
        //{
        //    BreadOrders = new List<IBreadOrder>();
        //}

        //public double CalculateTotalPrice()
        //{
        //    double totalPrice = 0;
        //    foreach (IBreadOrder item in BreadOrders)
        //    {
        //        totalPrice += item.OrderPrice;
        //    }
        //    return totalPrice;
        //}

        //public void CreateBaguetteOrder(int quantity = 1)
        //{
        //    IBreadOrder breadOrder = new BreadOrder(quantity, new Baguette());
        //    BreadOrders.Add(breadOrder);
        //}

        //public void CreateWhiteBreadOrder(int quantity = 1)
        //{
        //    IBreadOrder breadOrder = new BreadOrder(quantity, new WhiteBread());
        //    BreadOrders.Add(breadOrder);
        //}

        //public void CreateEspecialityOfTheOffice(int quantity = 1)
        //{
        //    IBreadOrder breadOrder = new BreadOrder(quantity, new HamburguerBun());
        //    BreadOrders.Add(breadOrder);
        //}
        //public void ClearTheOrder()
        //{
        //    BreadOrders.Clear();
        //}


        //public void PrepareAllOrders(string officeId)
        //{
        //    if (BreadOrders.Count == 0)
        //    {
        //        Console.WriteLine("There are no orders to dispatch");
        //        return;
        //    }

        //    foreach (var breadOrder in BreadOrders)
        //    {
        //        breadOrder.Bread.Prepare(breadOrder.Quantity);
        //    }

        //    Console.WriteLine($"Total cost: {CalculateTotalPrice()}");
        //}
    }
}
