

namespace Front.Responses
{
    internal class OfficeResponse
    {
        public string OfficeId { get; set; } = Guid.NewGuid().ToString();
        public int OfficeType { get; set; }

    }
}
