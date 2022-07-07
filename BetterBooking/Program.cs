using System;

namespace BetterBooking
{
    class Program
    {
        public const string DATABASE = "database.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy na BetterBooking");
            //Console.WriteLine("Właściciel hotelu / Turysta");

            Console.WriteLine("1. Właściciel hotelu \n2. Turysta");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine($"Wybrałeś opcje: {choice}");

            ItemService itemService = new ItemService();

            if (choice == 1)
            {
                Console.WriteLine("1. Dodaj hotel \n2. Info hotel \n3. Usuń hotel");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Wybrałeś: Dodaj hotel");
                    // Owners owners = new Owners() { Id = 1, Name = "Hotel JEDEN"};
                    itemService.AddItem();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Wybrałeś: Info hotel");
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Wybrałeś: Usuń hotel");
                    itemService.RemoveItem();
                }
                else
                {
                    Console.WriteLine("zamkniujsda sdsa");
                }

            }else if (choice == 2)
                    {
                Console.WriteLine("1. Lokalizacja \n2. Standard - VIP, Standard, Biedak \n3. Cena \n4. Pokoje \n5. Dostępność w czasie");
                choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    Console.WriteLine("1. Lokalizacja");
                }
                else if (choice == 2) {
                    Console.WriteLine("2. Standard - VIP, Standard, Biedak");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("3. Cena");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("3. Pokoje");
                }
                else if (choice == 5)
                {
                    Console.WriteLine("5. Dostępność w czasie");
                }
                else
                {
                    Console.WriteLine("duap");
                }
            }
                            
            else {
                Console.WriteLine("Zamknij program");
            }

            /*Console.WriteLine("1. Lokalizacja");
            Console.WriteLine("2. Standard - VIP, Standard");
            Console.WriteLine("3. Cena");
            Console.WriteLine("4. Pokoje");
            Console.WriteLine("5. Dostępność w czasie");

            Console.WriteLine("1. Potwierdzenie rezerwacji");
            Console.WriteLine("2. Płatność / zaliczki");
            Console.WriteLine("3. Oceny hotelu");
            Console.WriteLine("4. Anulowanie rezerwacji");*/
            




            //  Owners owners = new Owners() { Id = 1, Name = "Hotel Jeden" };

            //Console.WriteLine(owners.Id);

        }

    }
}