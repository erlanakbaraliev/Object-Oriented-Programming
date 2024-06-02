using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class Carp : Fish
    {
        public static Carp carp = new Carp();
        private Carp() { }
        public override int Mult()
        {
            return 2;
        }
        public override bool IsCarp()
        {
            return true;
        }
    }
}
