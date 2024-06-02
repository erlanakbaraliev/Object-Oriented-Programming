using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Party
    {
        public string name;
        public List<Congressmen> cmen = new List<Congressmen>();
        public Party(string name, Parliament p)
        {
            this.name = name;
            p.Establish(this);
        }
    }
}
