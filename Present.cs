using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
   public class Present
    {
        public string name;
        public int price;

        public Present(string Name,int Price)
        {
            name = Name;
            price = Price;
        }

        public override string ToString()
        {
            return name + " " + price;
        }
    }
}
