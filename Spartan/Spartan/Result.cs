using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Result
    {
        private int min;
        private int sec;
        private Competitor comp;
        private Category cat;
        public Result(int m, int s, Competitor c, Category cath)
        {
            if (m <= 0 || s < 0 || s > 59) { throw new Exception(); }
            min = m;
            sec = s;
            comp = c;
            cat = cath;
        }
        public Category Cat() { return cat; }
        public Competitor Comp() { return comp; }
        public int Min() { return min; }
        public int Sec() { return sec; }
    }
}
