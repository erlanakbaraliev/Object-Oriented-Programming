using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class M : Size
    {
        public static M m = new M();
        private M()
        {
        }
        public override int Point(Ball ball)
        {
            return 1;
        }

        public override int Point(Doll doll)
        {
            return 1;
        }

        public override int Point(Teddy teddy)
        {
            return 2;
        }
    }
}
