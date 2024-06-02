using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class Gallery
    {
        public class GuestsEmptyException: Exception { };
        public List<Guest> guests = new List<Guest>();
        public void Winner()
        {
            if(guests.Count == 0)
            {
                throw new GuestsEmptyException();
            }

            Guest g = guests.ElementAt(0);
            foreach (Guest guest in guests)
            {
                if(guest.Result() > g.Result())
                {
                    g = guest;
                }
            }

            Console.WriteLine("The guest with the most valuable prizes: " + g.name);
        }
    }
}
