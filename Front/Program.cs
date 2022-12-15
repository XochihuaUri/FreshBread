using BakeryFreashBread.models.Services;
using Front.Services;

namespace Front
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MainOffice mainOffice = await ConnectionToDB.GetMainOfficeAsync();
            SecondOffice secondOffice = await ConnectionToDB.GetSecondOfficeAsync();
            while (true)
            {
                Console.WriteLine("Insert the office's number you want to choose: \n" +
                                  "1.- Main Office\n" +
                                  "2.- Second Office");
                var officeSelected = Console.ReadLine();
                switch (officeSelected)
                {
                    case "1":
                        SelectOffice.SelectMainOffice(mainOffice);
                        break;
                    case "2":
                        SelectOffice.SelectSecondOffice(secondOffice);
                        break;
                    default:
                        break;
                }
            }
        }
    }  
}