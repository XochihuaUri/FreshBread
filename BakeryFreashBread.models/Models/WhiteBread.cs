

using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Models
{
    public class WhiteBread : IBread
    {
        public double Price { get; set; }
        public int Flour { get; set; }
        public int Water { get; set; }
        public int Salt { get; set; }
        public int Yeast { get; set; }
        public int Sugar { get; set; }
        public int Milk { get; set; }
        public int Butter { get; set; }
        public double CookingTime { get; set; }
        public double RestingTime { get; set; }
        public double FermentTime { get; set; }
        public double CookingTemperature { get; set; }
        public WhiteBread()
        {
            Price = 50;
            Flour = 1000;
            Water = 280;
            Salt = 20;
            Yeast = 20;
            Sugar = 80;
            Milk = 60;
            Butter = 100;
            CookingTime = 30;
            RestingTime = 1;
            FermentTime = 4;
            CookingTemperature = 180;
        }
    }
}
