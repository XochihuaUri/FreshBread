using BakeryFreashBread.models.Interfaces;
using Front.Requests;
using Front.Responses;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Front.Services
{
    public static class BreadOrderActions
    {
        public static async Task<BreadOrderResponse> CreateBreadOrder(string orderId, IBreadOrder breadOrder)
        {
            BreadOrderPost breadOrderToPost = new BreadOrderPost(breadOrder.BreadType, breadOrder.Quantity, breadOrder.Bread.Price, orderId);
            var json = JsonConvert.SerializeObject(breadOrderToPost);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://localhost:7228/api/breadOrder";
            var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            var result = await response.Content.ReadAsStringAsync();
            BreadOrderResponse breadOrderResponse = JsonConvert.DeserializeObject<BreadOrderResponse>(result);
            return breadOrderResponse;
        }
    }
}
