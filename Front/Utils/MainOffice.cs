using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Services
{
    public class MainOffice : IOffice
    {
        public IBaker Baker { get; set; }
        public string OfficeId { get; set; } = Guid.NewGuid().ToString();
        public OfficeType OfficeType { get; set; }
        public MainOffice()
        {
            Baker = new MainBaker();
            OfficeType = OfficeType.MainOffice;
        }
        
    }
}
