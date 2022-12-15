

using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Services
{
    public class MainOffice
    {
        public MainBaker Baker { get; set; }
        public string OfficeId { get; set; } = Guid.NewGuid().ToString();
        public MainOffice()
        {
            Baker = new MainBaker();
        }
        
    }
}
