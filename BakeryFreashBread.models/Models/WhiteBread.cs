

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
            Price = 2.5;
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
        public void Prepare(int quantity = 1)
        {
            Console.WriteLine($"Mixing the {Flour * quantity} grs of flour, " +
                             $"{Water * quantity} gr of water, " +
                             $"{Yeast * quantity} gr of yeast, " +
                             $"{Salt * quantity} gr of salt, " +
                             $"{Sugar * quantity} gr of sugar, " +
                             $"{Butter * quantity} gr of butter and " +
                             $"{Milk * quantity} gr of milk");
            Thread.Sleep(500);
            if (quantity > 1)
            {
                Console.WriteLine("Cut the dough");
                Thread.Sleep(500);
            }
            Console.WriteLine($"Let the dough ferment {FermentTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine("Shape the dough");
            Thread.Sleep(500);
            Console.WriteLine($"Let the dough rest {RestingTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine($"Cook for {CookingTime} minutes at {CookingTemperature}º");
            Thread.Sleep(800);
            Console.WriteLine("Bread order prepared");
            Thread.Sleep(1000);
        }
    }
}
