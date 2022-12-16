
namespace Front.Requests
{
    public class BreadOrderPost
    {
        public BreadType BreadType { get; set; }
        public int Quantity { get; set; }
        public double BreadPrice { get; set; }
        public string OrderId { get; set; }
        public BreadOrderPost(BreadType breadType, int quantity, double breadPrice, string orderId)
        {
            BreadType = breadType;
            Quantity = quantity;
            BreadPrice = breadPrice;
            OrderId = orderId;
        }
    }

    public enum BreadType
    {
        Bagguete = 1,
        WhiteBread = 2,
        MilkBread = 3,
        HamburguerBun = 4
    }
}
