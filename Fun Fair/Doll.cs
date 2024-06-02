using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class Doll : Prize
    {
        public Doll(Size size) : base(size)
        {
        }

        public override int totalPoint()
        {
            return GetSize().Point(this);
        }
    }
}
