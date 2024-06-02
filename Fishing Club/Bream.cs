using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class Bream : Fish
    {
        public static Bream bream = new Bream();
        private Bream() { }
        public override int Mult()
        {
            return 1;
        }
        public override bool IsBream()
        {
            return true;
        }
    }
}
