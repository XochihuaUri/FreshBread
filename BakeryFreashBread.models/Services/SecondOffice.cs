

namespace BakeryFreashBread.models.Services
{
    public class SecondOffice
    {
        SecondBaker Baker { get; set; }
        public SecondOffice()
        {
            Baker = new SecondBaker();
        }
    }
}
