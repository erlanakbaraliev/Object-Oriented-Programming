using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public abstract class Fish
    {
        public abstract int Mult();
        public virtual bool IsCarp()
        {
            return false;
        }
        public virtual bool IsBream()
        {
            return false;
        }
        public virtual bool IsCatf()
        {
            return false;
        }
    }
}
