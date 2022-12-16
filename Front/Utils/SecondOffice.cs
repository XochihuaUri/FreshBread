using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Services
{
    public class SecondOffice : IOffice
    {
        public IBaker Baker { get; set; }
        public string OfficeId { get; set; } = Guid.NewGuid().ToString();
        public OfficeType OfficeType { get; set; }
        public int BreadsRemaining { get; set; }
        public SecondOffice()
        {
            Baker = new SecondBaker();
            OfficeType = OfficeType.SecondOffice;
            BreadsRemaining = 100;
        }
    }
}
