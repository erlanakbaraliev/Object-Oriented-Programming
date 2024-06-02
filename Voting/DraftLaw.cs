using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public abstract class DraftLaw
    {
        public string date;
        public string ID;
        public List<bool> votes = new List<bool>();
        public Parliament parliament;
        public List<Congressmen> cmen = new List<Congressmen>();
        protected DraftLaw(string d, string ID)
        {
            this.date = d;
            this.ID = ID;
        }
        protected int YesCount()
        {
            int cnt = 0;
            foreach(bool e in votes)
            {
                if(e)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        public virtual bool IsValid()
        {
            return false;
        }
        public bool Abstain(Party p)
        {
            foreach(Congressmen c in cmen)
            {
                if(c.party == p)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
