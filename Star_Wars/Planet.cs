using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    public class NoShipsInThePlanetException: Exception { };
    public class Planet
    {
        private List<Starship> ships = new List<Starship>();
        private string Name;
        public Planet(string name)
        {
            Name = name;
        }
        public string GetName() { return Name; }
        public int ShipCount()
        {
            return ships.Count();
        }
        public void Protect(Starship s)
        {
            ships.Add(s);
        }
        public void Leave(Starship s)
        {
            ships.Remove(s);
        }
        public double TotalShield()
        {
            double total = 0;
            foreach(Starship s in ships)
            {
                total += s.GetShield();
            }

            return total;
        }
        public Starship MaxPower()
        {
            if(ships.Count() < 1)
            {
                throw new NoShipsInThePlanetException();
            }
            else
            {
                bool found = false;

                Starship maxShip = ships.ElementAt(0);
                double maxPower = 0;
                foreach(Starship ship in ships)
                {
                    if(!found)
                    {
                        maxShip = ship;
                        maxPower = ship.Power();
                        found = true;
                    }
                    else if(found && ship.Power() > maxPower)
                    {
                        maxShip = ship;
                        maxPower = ship.Power();
                    }
                }
                return maxShip;
            }
        }
    }
}
