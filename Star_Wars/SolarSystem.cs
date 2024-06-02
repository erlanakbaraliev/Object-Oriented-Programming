using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Star_Wars
{
    public class SolarSystem
    {
        public List<Planet> planets = new List<Planet>();

        public SolarSystem()
        {
            TextFileReader reader = new TextFileReader("input.txt");

            reader.ReadInt(out int nPlanets);
            for (int i = 0; i < nPlanets; i++)
            {
                reader.ReadString(out string planetName);
                reader.ReadInt(out int nProtectors);

                Planet planet = new Planet(planetName);
                planets.Add(planet);

                for (int j = 0; j < nProtectors; j++)
                {
                    Starship ship;

                    reader.ReadString(out string shipName);
                    reader.ReadString(out string shipType);
                    reader.ReadInt(out int shield);
                    reader.ReadInt(out int armour);
                    reader.ReadInt(out int guards);


                    if (shipType.Equals("Destroyer"))
                    {
                        ship = new Destroyer(shipName, shield, armour, guards);
                    }
                    else if (shipType.Equals("Transport"))
                    {
                        ship = new Transport(shipName, shield, armour, guards);
                    }
                    else if (shipType.Equals("Ironclad"))
                    {
                        ship = new Ironclad(shipName, shield, armour, guards);
                    }
                    else
                    {
                        Console.WriteLine("Wrong ship type");
                        return;
                    }

                    ship.Protect(planet);
                }
            }
        }
        public bool MaxPowerShip()
        {
            if (planets.Count() == 0)
            {
                Console.WriteLine("No planets to find max from");
                return false;
            }
            bool found = false;

            double maxPower = 0.0;
            Starship maxShip = planets.ElementAt(0).MaxPower();

            foreach (Planet p in planets)
            {
                try
                {
                    if (!found && p.ShipCount() > 0)
                    {
                        maxPower = p.MaxPower().Power();
                        maxShip = p.MaxPower();
                        found = true;
                    }
                    else if (found && p.ShipCount() > 0)
                    {
                        if (p.MaxPower().Power() > maxShip.Power())
                        {
                            maxPower = p.MaxPower().Power();
                            maxShip = p.MaxPower();
                        }
                    }
                }
                catch (NoShipsInThePlanetException)
                {
                    Console.WriteLine("NoShipsInThePlanetException for maxPower");
                }
            }

            if (found)
            {
                Console.WriteLine("Greatest ship name: " + maxShip.GetName() + " Power: " + maxPower);
            }
            else
            {
                Console.WriteLine("No start ship protects a planet");
            }
            return found;
        }
        public void Unprotected()
        {
            Console.WriteLine("Unprotected planets:");

            foreach (Planet p in planets)
            {
                if (p.ShipCount() == 0)
                {
                    Console.WriteLine(p.GetName());
                }
            }
        }
    }
}
