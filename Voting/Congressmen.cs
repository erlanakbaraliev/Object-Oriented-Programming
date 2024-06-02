using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Congressmen
    {
        public Parliament parliament;
        public string name;
        public Party party;
        public Congressmen(string name)
        {
            this.name = name;
        }
        public void Vote(bool vote, string ID)
        {
            if (parliament == null)
            {
                throw new ArgumentException();
            }
            parliament.Vote(this, vote, ID);
        }
        public void Enter(Party p)
        {
            if (party != null || p == null)
            {
                throw new InvalidOperationException();
            }
            party = p;
            p.cmen.Add(this);
        }
        public void Leave()
        {
            if (party == null)
            {
                throw new InvalidOperationException();
            }
            party.cmen.Remove(this);
            party = null;
        }
    }
}
