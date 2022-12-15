using BakeryFreashBread.models.Services;
using Front.Responses;
using Newtonsoft.Json;

namespace Front.Services
{
    public static class ConnectionToDB
    {
        
        public static async Task<MainOffice> GetMainOfficeAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:7228/api/offices").Result.Content.ReadAsStringAsync();
            if (response == null)
            {
                throw new Exception("There are no offices");
            }
            List<OfficeResponse> officeResponses = JsonConvert.DeserializeObject<List<OfficeResponse>>(response);

            OfficeResponse officeResponse = (from office in officeResponses where office.OfficeType == 1 select office).First();
            MainOffice mainOffice = new MainOffice() { OfficeId = officeResponse.OfficeId };

            return mainOffice;
        }

        public static async Task<SecondOffice> GetSecondOfficeAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://localhost:7228/api/offices").Result.Content.ReadAsStringAsync();
            if (response == null)
            {
                throw new Exception("There are no offices");
            }
            List<OfficeResponse> officeResponses = JsonConvert.DeserializeObject<List<OfficeResponse>>(response);

            OfficeResponse officeResponse = (from office in officeResponses where office.OfficeType == 2 select office).First();
            SecondOffice secondOffice = new SecondOffice() { OfficeId = officeResponse.OfficeId};

            return secondOffice;
        }
    }
}
