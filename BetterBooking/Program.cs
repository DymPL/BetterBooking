using System;

namespace BetterBooking
{
    class Program
    {
        public const string DATABASE = "database.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy na BetterBooking");
            Console.WriteLine("Właściciel hotelu / Turysta");

            Console.WriteLine("1. Dodaj hotel");
            Console.WriteLine("2. Usuń hotel");

            Console.WriteLine("1. Lokalizacja");
            Console.WriteLine("2. Standard - VIP, Standard");
            Console.WriteLine("3. Cena");
            Console.WriteLine("4. Pokoje");
            Console.WriteLine("5. Dostępność w czasie");

            Console.WriteLine("1. Potwierdzenie rezerwacji");
            Console.WriteLine("2. Płatność / zaliczki");
            Console.WriteLine("3. Oceny hotelu");
            Console.WriteLine("4. Anulowanie rezerwacji");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine($"Wybrałeś opcje: {choice}");

        }

    }
}