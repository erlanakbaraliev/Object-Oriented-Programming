using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    public class Destroyer : Starship
    {
        public Destroyer(string name, int shield, int armour, int guards) : base(name, shield, armour, guards)
        {
        }

        public override double Power()
        {
            return shield / 2;
        }
    }
}
