﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace BetterBooking
{
    public class OwnerAction
    {
        public OwnerManager OwnerManager { get; set; } = new OwnerManager();

        public void OwnerHotelMenu()
        {
            Console.WriteLine("\nCo chcesz wykonać:");

            int userInput = 0;

            var menuWmenu = new Menu();

            while (userInput != 4)
            {
                Console.WriteLine("\n1 - Dodawanie obiektu");
                Console.WriteLine("2 - Usuwanie obiektu");
                Console.WriteLine("3 - Wypisywanie listy obiektów");
                Console.WriteLine("4 - Powrót");
                Console.WriteLine("5 - Wyszukaj po nazwie");
                Console.WriteLine("6 - Wyszukaj po lokalizacji");

                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        AddHotel();
                        break;
                    case 2:
                        DeleteHotel();
                        break;
                    case 3:
                        AllOwners();
                        break;
                    case 4:
                        menuWmenu.MenuWMenu();
                        break;
                    case 5:
                        FindByName();
                        break;
                    case 6:
                        FindByLocation();
                        break;
                    default:
                        Console.WriteLine("Podaną złą wartość");
                        OwnerHotelMenu();
                        break;

                }
            }
        }
        public void AddHotel()
        {
            Console.WriteLine("Podaj nazwę hotelu:");
            var hotelName = Console.ReadLine();

            Console.WriteLine("Podaj kwotę za dobę:");
            var hotelPrice = Console.ReadLine();

            Console.WriteLine("Podaj datę przyjazdu: dd.mm.rrrr ");
            DateTime dataprzyjazdu = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Podaj datę wyjazdu: dd.mm.rrrr ");
            DateTime dataodjazdu = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Podaj lokalizacje: ");
            var location = Console.ReadLine();

            var hotelPriceDecimal = default(decimal);

            while (!decimal.TryParse(hotelPrice, out hotelPriceDecimal))
            {
                Console.WriteLine("Podano niepoprawną kwotę");
                Console.WriteLine("Podaj poprawną kwotę:");

                hotelPrice = Console.ReadLine();
            }
            OwnerManager.AddHotel(hotelName, hotelPriceDecimal, dataprzyjazdu, dataodjazdu, location);
        }

        public void DeleteHotel()
        {
            Console.WriteLine("Podaj nazwę hotelu do usunięcia:");
            var hotelName = Console.ReadLine();

            OwnerManager.DeleteHotel(hotelName);
            Console.WriteLine("Udało się usunąc hotel");
        }

        public void AllOwners()
        {
            Console.WriteLine("Lista wszyskich dodanych hoteli: \n");
            foreach(var hotel in OwnerManager.AllOwners())
            {
                Console.WriteLine(hotel);
            }

        }
        public void FindByName()
        {
            Console.WriteLine("Jakiego hotelu szukasz: ");
            var find = Console.ReadLine();
            OwnerManager.FindByName(find);
        }

        public void FindByLocation()
        {
            Console.WriteLine("Podaj lokalizacje: ");
            var findbylocation = Console.ReadLine();
            OwnerManager.FindByLocation(findbylocation);
        }


    }

}
