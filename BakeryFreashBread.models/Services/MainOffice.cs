

using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Services
{
    public class MainOffice
    {
        MainBaker Baker { get; set; }
        public MainOffice()
        {
            Baker = new MainBaker();
        }
        
    }
}
