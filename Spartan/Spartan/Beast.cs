using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Beast : Category
    {
        public static Beast instance = new Beast();
        private Beast() { }
        public string Type()
        {
            return "beast";
        }
        public static Beast Instace() { return instance; }
    }
}
