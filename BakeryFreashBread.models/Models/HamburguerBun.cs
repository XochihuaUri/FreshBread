

using BakeryFreashBread.models.Interfaces;

namespace BakeryFreashBread.models.Models
{
    public class HamburguerBun : IBread
    {
        public double Price { get; set; }
        public int Flour { get; set; }
        public int Water { get; set; }
        public int Salt { get; set; }
        public int Yeast { get; set; }
        public int Sugar { get; set; }
        public int Milk { get; set; }
        public int Butter { get; set; }
        public int Egg { get; set; }
        public int SweetPotato { get; set; }
        public int SesameSeed { get; set; }
        public int Gilding { get; set; }
        public double CookingTime { get; set; }
        public double RestingTime { get; set; }
        public double FermentTime { get; set; }
        public double CookingTemperature { get; set; }
        public HamburguerBun()
        {
            Price = 10;
            Flour = 100;
            Water = 25;
            Salt = 2;
            Yeast = 4;
            Sugar = 6;
            Egg = 10;
            SweetPotato = 25;
            SesameSeed = 10;
            Gilding = 5;
            Milk = 5;
            CookingTime = 15;
            RestingTime = 0.5;
            FermentTime = 4;
            CookingTemperature = 180;
        }
    }
}
