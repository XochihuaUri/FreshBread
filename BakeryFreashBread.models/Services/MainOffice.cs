

using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Services
{
    public class MainOffice
    {
        public MainBaker Baker { get; set; }
        public MainOffice()
        {
            Baker = new MainBaker();
        }
        
    }
}
