using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBooking
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Localization { get; set; }
        public int Standard { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }
    }
}
