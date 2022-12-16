using Front.Requests;
using Newtonsoft.Json;

namespace Front.Responses
{
    public class BreadOrderResponse
    {
        public string BreadOrderId { get; set; }
        public BreadType BreadType { get; set; }
        public int Quantity { get; set; }
        public double BreadPrice { get; set; }
        public string OrderId { get; set; }
        [JsonConstructor]
        public BreadOrderResponse(BreadType breadType, int quantity, double breadPrice, string orderId, string breadOrderId)
        {
            BreadType = breadType;
            Quantity = quantity;
            BreadPrice = breadPrice;
            OrderId = orderId;
            BreadOrderId = breadOrderId;
        }
    }
}
