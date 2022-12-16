using BakeryFreashBread.models.Interfaces;
namespace Front.Services
{
    internal static class CreateOrder
    {

        public static void CreateNewOrder(IOffice office)
        {
            switch (office.OfficeType)
            {
                case OfficeType.MainOffice:
                    Print.DisplayMainBreads();
                    break;
                case OfficeType.SecondOffice:
                    Print.DisplaySecondBreads();
                    break ;

            }
            
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
                    office.Baker.CreateBaguetteOrder(quantity);
                    break;
                case "2":
                    office.Baker.CreateWhiteBreadOrder(quantity);
                    break;
                case "3":
                    office.Baker.CreateEspecialityOfTheOffice(quantity);
                    break;
                default:
                    break;
            }
        }
    }
}
