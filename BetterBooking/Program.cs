using System;

namespace BetterBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy na BetterBooking");

            var ownerAction = new OwnerAction();
            //ownerAction.OwnerOrSeekers();
            ownerAction.Action();

        }

    }
}