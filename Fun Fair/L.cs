using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class L : Size
    {
        public static L l = new L();
        private L()
        {
        }
        public override int Point(Ball ball)
        {
            return 1;
        }

        public override int Point(Doll doll)
        {
            return 2;
        }

        public override int Point(Teddy teddy)
        {
            return 3;
        }
    }
}
