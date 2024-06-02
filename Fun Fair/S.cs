using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class S : Size
    {
        public static S s = new S();
        private S()
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
            return 1;
        }
    }
}
