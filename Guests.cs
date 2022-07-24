using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    interface IMoveToShop
    {
        void MoveForAlco(Guest guest);

    }
    public class Guest : IMoveToShop
    {
        public string name;
        public Drink drink;
        public string preferences;
        public bool presence;
        Present present;

        public Guest(string Name, Drink Drink, string Preferences, bool Presence, Present Present) 
        {
            name = Name;
            drink = Drink;
            preferences = Preferences;
            presence = Presence;
            present = Present;
        }

        public override string ToString()
        {
            return "Guest: " + name + " " + drink + " " + preferences + " " + "Budet - " + present;
        }

        public void MoveForAlco(Guest guest)
        {
            Console.WriteLine(guest.name + " go to shop for the alco!");
        }
    }
}
