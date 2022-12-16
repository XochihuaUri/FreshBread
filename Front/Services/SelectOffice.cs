using BakeryFreashBread.models.Interfaces;

namespace Front.Services
{
    internal static class SelectOffice
    {
        public static async Task SelectNewOfficeAsync(IOffice office)
        {
            bool bucle = true;
            while (bucle)
            {
                Print.DisplayOfficeMenu();
                var actionSelected = Console.ReadLine();
                switch (actionSelected)
                {
                    case "1":
                        CreateOrder.CreateNewOrder(office);
                        break;
                    case "2":
                        await office.Baker.PrepareAllOrdersAsync(office.OfficeId);
                        break;
                    case "3":
                        bucle = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
