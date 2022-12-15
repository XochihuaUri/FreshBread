using BakeryFreashBread.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreashBread.models.Models
{
    public class MilkBread: IBread
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
        public int Honey { get; set; }
        public int LemonZest { get; set; }
        public int Vanilla { get; set; }
        public double CookingTime { get; set; }
        public double RestingTime { get; set; }
        public double FermentTime { get; set; }
        public double CookingTemperature { get; set; }
        public MilkBread()
        {
            Price = 1.5;
            Flour = 55;
            Water = 25;
            Salt = 1;
            Yeast = 3;
            Sugar = 6;
            Egg = 10;
            Honey = 2;
            LemonZest = 1;
            Vanilla = 1;
            Milk = 20;
            CookingTime = 15;
            RestingTime = 0.2;
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
                             $"{Milk * quantity} gr of milk, " +
                             $"{Honey * quantity} gr of honey," +
                             $"{LemonZest * quantity} of lemon zest and " +
                             $"{Vanilla * quantity} of vanilla");
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
            Console.WriteLine($"Cook for {CookingTime} minutes at {CookingTemperature}º");
            Thread.Sleep(1000);
            Console.WriteLine("Bread order prepared");
            Thread.Sleep(1000);
        }
    }
}
