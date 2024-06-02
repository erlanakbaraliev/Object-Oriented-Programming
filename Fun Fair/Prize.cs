using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public abstract class Prize
    {
        Size size;
        public Prize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return size;
        }
        public abstract int totalPoint();
        
    }
}
