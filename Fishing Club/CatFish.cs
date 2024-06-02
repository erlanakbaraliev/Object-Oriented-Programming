using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class CatFish : Fish
    {
        public static CatFish catFish = new CatFish();
        private CatFish() { }
        public override int Mult()
        {
            return 3;
        }
        public override bool IsCatf()
        {
            return true;
        }
    }
}
