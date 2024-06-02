using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class XL : Size
    {
        public static XL xl = new XL();
        private XL()
        {
        }
        public override int Point(Ball ball)
        {
            return 3;
        }

        public override int Point(Doll doll)
        {
            return 2;
        }

        public override int Point(Teddy teddy)
        {
            return 4;
        }
    }
}
