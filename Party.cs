using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    
        
    static class Party 
    {

        static public void ShowGuests(Guest[] guests)
        {
            for (int i = 0; i < guests.Length; i++)
            {
                Console.WriteLine(guests[i]);
            }

        }
        static public void Dance(Guest[] guests)
        {
            for (int i = 0; i < guests.Length; i++)
            {
                Console.WriteLine(guests[i].name + " Dance");
            }
        }

        static public void Drink(Guest[] guests)
        {
            for (int i = 0; i < guests.Length; i++)
            {
                Console.WriteLine(guests[i].name + " Drink - " + guests[i].drink);
            }
        }

       

    }
}
