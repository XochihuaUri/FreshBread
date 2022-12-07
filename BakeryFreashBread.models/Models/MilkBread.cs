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
            Price = 10;
            Flour = 1000;
            Water = 280;
            Salt = 20;
            Yeast = 20;
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
    }
}
