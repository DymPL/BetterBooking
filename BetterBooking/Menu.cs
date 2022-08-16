using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace BetterBooking
{
    public class Menu
    {
        public void MenuWMenu()
        {
            Console.WriteLine("Witamy na BetterBooking");
            Console.WriteLine("Wybierz opcje");
            Console.WriteLine("1. Hotel");
            Console.WriteLine("2. Atrakcje");
            Console.WriteLine("3. Wydarzenia");
            Console.WriteLine("4. Wyjście");

            var ownerAction = new OwnerAction();

            var userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("\nWybrano: 1. Hotel");
                    ownerAction.OwnerHotelMenu();
                    break;
                case 2:
                    Console.WriteLine("Wybrano: Atrakcje");
                    break;
                case 3:
                    Console.WriteLine("Wybrano: Wydarzenia");
                    break;
                case 4:
                    Console.WriteLine("Do widzenia");
                    break;
                default:
                    Console.WriteLine("Podaną złą wartość");
                    MenuWMenu();
                    break;
            }
        }
    }
}
