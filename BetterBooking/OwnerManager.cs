﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBooking
{
    public class OwnerManager
    {
        private List<Owners> Owners { get; set; }

        public OwnerManager()
        {
            Owners = new List<Owners>();
        }

        public void AddHotel(string name, decimal price, DateTime data, DateTime data1)
        {
            var owner = new Owners
            {
                Name = name,
                Price = price,
                DateTimeArrive = data,
                DateTimeDeparture = data1,
            };
            Owners.Add(owner);
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
                var ownerString = count + ". " + owner.Name + " - " + owner.Price + " zł" + " Data przyjazdu " + owner.DateTimeArrive.ToString("dd.MM.yyyy") + " Data wyjazdu: " + owner.DateTimeDeparture.ToString("dd.MM.yyyy");
                count++;

                ownerStrings.Add(ownerString);
            }

            return ownerStrings;
        }
    }
}
