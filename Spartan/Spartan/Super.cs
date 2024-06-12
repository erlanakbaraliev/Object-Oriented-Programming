using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Super : Category
    {
        public static Super instance = new Super();
        private Super() { }
        public string Type()
        {
            return "super";
        }
        public static Super Instance() { return instance; }
    }
}
