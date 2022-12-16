

using Front.Requests;
using Front.Responses;
using Newtonsoft.Json;
using System.Text;

namespace Front.Services
{
    public static class OrderActions
    {
        public static async Task<OrderResponse> CreateOrder(string officeId)
        {
            OrderPost orderToPost = new OrderPost(officeId);
            var json = JsonConvert.SerializeObject(orderToPost);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://localhost:7228/api/order";
            var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            var result = await response.Content.ReadAsStringAsync();
            OrderResponse orderResponse = JsonConvert.DeserializeObject<OrderResponse>(result);
            return orderResponse;
        }
    }
}
