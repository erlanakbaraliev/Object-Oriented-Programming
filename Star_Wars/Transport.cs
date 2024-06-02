using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    public class Transport : Starship
    {
        public Transport(string name, int shield, int armour, int guards) : base(name, shield, armour, guards)
        {
        }
        public override double Power()
        {
            return guards;
        }
    }
}
