using BakeryFreashBread.models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Services
{
    internal static class CreateOrder
    {
        public static void CreateMainOrder(MainOffice mainOffice)
        {
            Print.DisplayMainBreads();
            var breadSelected = Console.ReadLine();
            Console.WriteLine("Insert the quantity of breads");
            var quantityInput = Console.ReadLine();
            if (quantityInput == null)
            {
                throw new Exception("Invalid quantity");
            }
            int quantity = Int32.Parse(quantityInput);

            switch (breadSelected)
            {
                case "1":
                    mainOffice.Baker.CreateBaguetteOrder(quantity);
                    break;
                case "2":
                    mainOffice.Baker.CreateWhiteBreadOrder(quantity);
                    break;
                case "3":
                    mainOffice.Baker.CreateMilkBreadOrder(quantity);
                    break;
                default:
                    break;
            }
        }


        public static void CreateSecondOrder(SecondOffice secondOffice)
        {
            Print.DisplaySecondBreads();
            var breadSelected = Console.ReadLine();
            Console.WriteLine("Insert the quantity of breads");
            var quantityInput = Console.ReadLine();
            if (quantityInput == null)
            {
                throw new Exception("Invalid quantity");
            }
            int quantity = Int32.Parse(quantityInput);
            switch (breadSelected)
            {
                case "1":
                    secondOffice.Baker.CreateBaguetteOrder(quantity);
                    break;
                case "2":
                    secondOffice.Baker.CreateWhiteBreadOrder(quantity);
                    break;
                case "3":
                    secondOffice.Baker.CreateHamburguerBunOrder(quantity);
                    break;
                default:
                    break;
            }
        }
    }
}
