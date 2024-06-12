using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Sprint : Category
    {
        public static Sprint instance = new Sprint();
        private Sprint() { }
        public string Type()
        {
            return "sprint";
        }
        public static Sprint Instance() { return instance;}
    }
}
