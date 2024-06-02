using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Fair
{
    public class Guest
    {
        public string name;
        private List<Prize> prizes = new List<Prize>();
        public Guest(string name)
        {
            this.name = name;
        }
        public void Visit(Gallery g)
        {
            g.guests.Add(this);
        }
        public void Win(Prize p)
        {
            prizes.Add(p);
        }
        public int Result()
        {
            int sum = 0;
            foreach (Prize p in prizes)
            {
                sum += p.totalPoint();
            }
            return sum;
        }
    }
}
