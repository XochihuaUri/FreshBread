using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Services
{
    internal static class Print
    {
        public static void DisplayOfficeMenu()
        {
            Console.WriteLine("Insert the option's number you want to choose: \n" +
                                  "1.- Add order\n" +
                                  "2.- Prepare all orders\n" +
                                  "3.- Go back to main menu");
        }
        public static void DisplayMainBreads()
        {
            Console.WriteLine("Insert the bread 's number you want to choose: \n" +
                                  "1.- Bagguete $2.0\n" +
                                  "2.- White Bread $2.5\n" +
                                  "3.- Milk Bread $1.5\n" +
                                  "4.- Go back");
        }
        public static void DisplaySecondBreads()
        {
            Console.WriteLine("Insert the bread 's number you want to choose: \n" +
                                  "1.- Bagguete $2.0\n" +
                                  "2.- White Bread $2.5\n" +
                                  "3.- Hamburguer bun $1.0 \n" +
                                  "4.- Go back");
        }
    }
}
