using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Responses
{
    public class OrderResponse
    {
        public string OfficeId { get; set; }
        public string OrderId { get; set; }
        [JsonConstructor]
        public OrderResponse(string officeId, string orderId)
        {
            OfficeId = officeId;
            OrderId = orderId;
        }
    }
}
