using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    public enum Drink 
    {
        Alco,
        NonAlco
    }

    class Program 
    {

        delegate void Tusa(Guest[] guests);
        static void Main(string[] args)
        {
            Present bodyaPresent = new Present("Golf3", 4000);
            Present vladosPresent = new Present("Golf4", 5000);
            Present money = new Present("USD", 1000000);

            Guest bodya = new Guest("Bogdan", Drink.Alco, "Bitches", true, bodyaPresent);
            Guest vlad = new Guest("Vlad", Drink.Alco, "Bitches", true, vladosPresent);
            Guest masha = new Guest("Masha", Drink.Alco, "Mens", true, money);
            Guest angelina = new Guest("Angelina", Drink.NonAlco, "Mens", true, money);
            Guest alina = new Guest("Alina", Drink.Alco, "Mens", true, money);

            
            
            

            Guest[] guests = new Guest[5];

            guests[0] = bodya;
            guests[1] = vlad;
            guests[2] = masha;
            guests[3] = angelina;
            guests[4] = alina;

            Party.ShowGuests(guests);
            Party.Dance(guests);
            Party.Drink(guests);

            vlad.MoveForAlco(vlad);

            //Tusa tusovka;
            //tusovka = Party.ShowGuests;
            //tusovka += Party.Drink;
            //tusovka += Party.Dance;

            //tusovka -= Party.ShowGuests;

            //tusovka(guests);

              

            Console.ReadKey();

        }
    }
}
