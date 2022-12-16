
using BakeryFreashBread.models.Interfaces;
using Front.Requests;

namespace Front.Models

{
    public class BreadOrder : IBreadOrder
    {
        public int Quantity { get; set; }
        public double OrderPrice { get; set; }
        public IBread Bread{ get; set; }
        public BreadType BreadType { get; set; }
        public BreadOrder(int quantity, IBread bread, BreadType breadType)
        {
            Quantity = quantity;
            OrderPrice = quantity * bread.Price;
            Bread = bread;
            BreadType = breadType;
        }
    }
}
