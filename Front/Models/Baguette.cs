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
            Price = 2.0;
            Flour = 280;
            Water = 210;
            Salt = 10;
            Yeast = 5;
            CookingTime = 15;
            RestingTime = 0.5;
            FermentTime = 24;
            CookingTemperature = 270;
        }

        public void Prepare(int quantity = 1)
        {
            Console.WriteLine($"Mixing the {Flour * quantity} grs of flour, " +
                             $"{Water * quantity} gr of water, " +
                             $"{Yeast * quantity} gr of yeast and " +
                             $"{Salt * quantity} gr of salt");
            Thread.Sleep(500);
            Console.WriteLine($"Leet the dough rest {RestingTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine("Fold the dough");
            Thread.Sleep(500);
            Console.WriteLine($"Let the dough rest {RestingTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine("Fold the dough");
            Thread.Sleep(500);
            Console.WriteLine($"Let the dough ferment {FermentTime} hrs");
            Thread.Sleep(500);
            if (quantity > 1)
            {
                Console.WriteLine("Cut the dough");
                Thread.Sleep(500);
            }
            Console.WriteLine("Shape the dough");
            Thread.Sleep(500);
            Console.WriteLine($"Let the dough rest {RestingTime} hrs");
            Thread.Sleep(500);
            Console.WriteLine($"Cook for {CookingTime} minutes at {CookingTemperature}º");
            Thread.Sleep(500);
            Console.WriteLine("Bread order prepared");
            Thread.Sleep(1000);
        }
    }
}
