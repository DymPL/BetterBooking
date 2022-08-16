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
    public class OwnerManager
    {
        private List<Owners> Owners { get; set; }

        public OwnerManager()
        {
            Owners = new List<Owners>();
            string readText = File.ReadAllText("hotels.json");
            var deserHotel = JsonSerializer.Deserialize<Owners>(readText);
        }

        public void AddHotel(string name, decimal price, DateTime data, DateTime data1, string location)
        {
            var owner = new Owners
            {
                Name = name,
                Price = price,
                DateTimeArrive = data,
                DateTimeDeparture = data1,
                Location = location,
            };
            Owners.Add(owner);
            string jsonSerializerResult = JsonSerializer.Serialize(owner);
            //Console.WriteLine(jsonSerializerResult);
            File.WriteAllText("hotels.json", jsonSerializerResult);


        }

        public void DeleteHotel(string name)
        {
            foreach (var owner in Owners) {
                if (owner.Name == name)
                {
                    Owners.Remove(owner);
                    return;
                }
            }
        }
        public List<string> AllOwners()
        {
            var ownerStrings = new List<string>();
            var count = 1;

            foreach (var owner in Owners) 
            {
                var ownerString = count + ". " + owner.Name + " - " + owner.Price + " zł\n" + "Data przyjazdu " + owner.DateTimeArrive.ToString("dd.MM.yyyy\n") + "Data wyjazdu: " + owner.DateTimeDeparture.ToString("dd.MM.yyyy\n") + "Lokalizacja: " + owner.Location;
                count++;

                ownerStrings.Add(ownerString);
            }

            return ownerStrings;

            
        }

        public void FindByName(string name)
        {
            foreach (var owner in Owners)
            {
                if (owner.Name == name)
                {
                    Console.WriteLine("Znaleziony: " + name + " - Cena za dobę: " + owner.Price);
                    return;
                }
            }
        }
        public List<string> FindByLocation(string location)
        {
            var ownerStrings = new List<string>();
            var count = 1;
            foreach (var llocation in Owners)
            {
                
                if (llocation.Location == location)
                {
                    Console.WriteLine("Hotele znalezione po lokalizacji: " + location + "\nNazwa hotelu: " + llocation.Name);
                    count++;
                }
            }
            return ownerStrings;
        }

    }
}
