
using BakeryFreashBread.models.Interfaces;
using Front.Services;

namespace Front
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IOffice mainOffice = await GetOffices.GetMainOfficeAsync();
            IOffice secondOffice = await GetOffices.GetSecondOfficeAsync();
            while (true)
            {
                Console.WriteLine("Insert the office's number you want to choose: \n" +
                                  "1.- Main Office\n" +
                                  "2.- Second Office");
                var officeSelected = Console.ReadLine();
                switch (officeSelected)
                {
                    case "1":
                        await SelectOffice.SelectNewOfficeAsync(mainOffice);
                        break;
                    case "2":
                        await SelectOffice.SelectNewOfficeAsync(secondOffice);
                        break;
                    default:
                        break;
                }
            }
        }
    }  
}