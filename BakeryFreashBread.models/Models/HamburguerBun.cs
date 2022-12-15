

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
            Price = 1.0;
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

        public void Prepare(int quantity = 1)
        {
            Console.WriteLine($"Mixing the {Flour * quantity} grs of flour, " +
                             $"{Water * quantity} gr of water, " +
                             $"{Yeast * quantity} gr of yeast, " +
                             $"{Salt * quantity} gr of salt, " +
                             $"{Sugar * quantity} gr of sugar, " +
                             $"{Egg * quantity} gr of egg, " +
                             $"{Butter * quantity} gr of butter, " +
                             $"{Milk * quantity} gr of milk and " +
                             $"{SweetPotato * quantity} gr of honey,");
            Thread.Sleep(500);
            if (quantity > 1)
            {
                Console.WriteLine("Cut the dough");
                Thread.Sleep(500);
            }

            Console.WriteLine($"Let the dough rest {RestingTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine("Shape the dough");
            Thread.Sleep(500);
            Console.WriteLine($"Let the dough rest {FermentTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine($"Place on top of the dough the {SesameSeed * quantity} gr of seamed seen" +
                $" and the {Gilding * quantity} gr the gilding");
            Thread.Sleep(500);
            Console.WriteLine($"Cook for {CookingTime} minutes at {CookingTemperature}º");
            Thread.Sleep(500);
            Console.WriteLine("Bread order prepared");
            Thread.Sleep(1000);
        }
    }
}
