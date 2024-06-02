using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    public abstract class Starship
    {
        protected string name;
        protected int armour { get; }
        protected int shield;
        protected int guards;
        protected Planet planet;

        public Starship(string name, int shield, int armour,  int guards)
        {
            this.name= name;
            this.shield = shield;
            this.armour = armour;
            this.guards = guards;
        }
        public void Protect(Planet p)
        {
            if(planet != null)
            {
                Console.WriteLine("The starship " + name + " is already protecting a planet");
                return;
            }
            planet = p;
            p.Protect(this);
        }
        public void Leave()
        {
            if(planet == null)
            {
                Console.WriteLine("No protection can be dropped, reason: no protection exists to drop");
                return;
            }
            planet.Leave(this);
            planet = null;
        }
        public abstract double Power();
        public string GetName() { return name; }
        public int GetShield() { return shield; }
    }
}
