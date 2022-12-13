using BakeryFreshBread.Api.Models;

namespace BakeryFreshBread.Api.Services
{
    public static class BreadOrderService
    {
        public static double GetTotalOrderBreadPrice(BreadOrderRequest breadOrderRequest)
        {
            return breadOrderRequest.BreadPrice * breadOrderRequest.Quantity;
        }
    }
}
