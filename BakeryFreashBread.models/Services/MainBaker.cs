using BakeryFreashBread.models.Interfaces;
using BakeryFreashBread.models.Models;
namespace BakeryFreashBread.models.Services
{
    public class MainBaker 
    {

        //public List<IBreadOrder> BreadOrders { get; set; }

        //public MainBaker()
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
        //    IBreadOrder breadOrder = new BreadOrder(quantity, new MilkBread());
        //    BreadOrders.Add(breadOrder);
        //}
        //public void ClearTheOrder()
        //{
        //    BreadOrders.Clear();
        //}

        //public void PrepareAllOrders()
        //{
        //    if(BreadOrders.Count == 0)
        //    {
        //        Console.WriteLine("There are no orders to dispatch");
        //        return;
        //    }
        //    foreach(var breadOrder in BreadOrders)
        //    {
        //        breadOrder.Bread.Prepare(breadOrder.Quantity);
        //        Thread.Sleep(1000);
        //    }
        //    Console.WriteLine($"Total cost: {CalculateTotalPrice()}");
        //}

        //void IBaker.PrepareAllOrders(string officeId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
