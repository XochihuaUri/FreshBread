

using Newtonsoft.Json;

namespace Front.Responses
{
    internal class OfficeResponse
    {
        public string OfficeId { get; set; }
        public int OfficeType { get; set; }
        public List<dynamic> Orders { get; set; }
        [JsonConstructor]
        OfficeResponse(string officeId, int officeType, List<dynamic> orders)
        {
            OfficeId = officeId;
            OfficeType = officeType;
            Orders = orders;
        }
    }
}
