using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    public class Ironclad : Starship
    {
        public Ironclad(string name, int shield, int armour, int guards) : base(name, shield, armour, guards)
        {
        }

        public override double Power()
        {
            return armour;
        }
    }
}
