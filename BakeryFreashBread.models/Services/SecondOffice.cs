

namespace BakeryFreashBread.models.Services
{
    public class SecondOffice
    {
        public SecondBaker Baker { get; set; }
        public string OfficeId { get; set; } = Guid.NewGuid().ToString();
        public SecondOffice()
        {
            Baker = new SecondBaker();
        }
    }
}
