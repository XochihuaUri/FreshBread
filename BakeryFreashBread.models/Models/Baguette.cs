using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Models
{
    public class Baguette: IBread
    {
        public double Price { get; set; }
        public int Flour { get; set; }
        public int Water { get; set; }
        public int Salt { get; set; }
        public int Yeast { get; set; }
        public double CookingTime { get; set; }
        public double RestingTime { get; set; }
        public double FermentTime { get; set; }
        public double CookingTemperature { get; set; }
        public Baguette()
        {
            Price = 8;
            Flour = 280;
            Water = 210;
            Salt = 10;
            Yeast = 5;
            CookingTime = 15;
            RestingTime = 0.5;
            FermentTime = 24;
            CookingTemperature = 270;
        }
    }
}
