using BakeryFreashBread.models.Services;

namespace Front.Services
{
    internal static class SelectOffice
    {
        public static void SelectMainOffice(MainOffice mainOffice)
        {
            bool office = true;
            while (office)
            {
                Print.DisplayOfficeMenu();
                var actionSelected = Console.ReadLine();
                switch (actionSelected)
                {
                    case "1":
                        CreateOrder.CreateMainOrder(mainOffice);
                        break;
                    case "2":
                        mainOffice.Baker.PrepareAllOrders();
                        break;
                    case "3":
                        office = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public static void SelectSecondOffice(SecondOffice secondOffice)
        {
            bool office = true;
            while (office)
            {
                Print.DisplayOfficeMenu();
                var actionSelected = Console.ReadLine();
                switch (actionSelected)
                {
                    case "1":
                        CreateOrder.CreateSecondOrder(secondOffice);
                        break;
                    case "2":
                        secondOffice.Baker.PrepareAllOrders();
                        break;
                    case "3":
                        office = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
