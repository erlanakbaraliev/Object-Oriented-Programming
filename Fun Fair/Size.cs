using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public abstract class Size
    {
        public abstract int Point(Ball ball);
        public abstract int Point(Doll doll);
        public abstract int Point(Teddy teddy);
    }
}
