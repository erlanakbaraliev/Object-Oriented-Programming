using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Parliament
    {
        public HashSet<Congressmen> cmen = new HashSet<Congressmen>();
        public HashSet<DraftLaw> laws = new HashSet<DraftLaw>();
        public List<Party> parties = new List<Party>();
        public Parliament(List<Congressmen> cm)
        {
            foreach(Congressmen c in cm)
            {
                c.parliament = this;
                if(!cmen.Contains(c))
                {
                    cmen.Add(c);
                }
            }
        }
        public void Submit(DraftLaw d)
        {
            bool found = false;
            foreach(DraftLaw e in laws)
            {
                if(e.ID.Equals(d.ID))
                {
                    found = true;
                    break;
                }
            }

            if(found)
            {
                throw new ArgumentException();
            }
            laws.Add(d);
            d.parliament = this;
        }
        public void Vote(Congressmen cm, bool b, string ID)
        {
            bool found = false;
            DraftLaw elem = null;
            foreach(DraftLaw t in laws)
            {
                if(t.ID.Equals(ID))
                {
                    found = true;
                    elem = t;
                    break;
                }
            }

            if(!found || elem == null)
            {
                throw new MissingMemberException();
            }
            if(elem.cmen.Contains(cm))
            {
                throw new ArgumentException();
            }
            elem.cmen.Add(cm);
            elem.votes.Add(b);
        }
        public List<string> ValidLaws()
        {
            List<string> valid = new List<string>();
            
            foreach(DraftLaw t in laws)
            {
                if(t.IsValid())
                {
                    valid.Add(t.ID);
                }
            }

            return valid;
        }
        public int AbstainCount()
        {
            int cnt = 0;
            foreach(Congressmen c in cmen)
            {
                int abstains = 0;
                foreach(DraftLaw l in laws)
                {
                    if(!l.cmen.Contains(c))
                    {
                        abstains++;
                    }
                }
                if(abstains > 2)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        public void Reject()
        {
            foreach(DraftLaw l in laws)
            {
                if(l.cmen.Count() == cmen.Count() && !l.IsValid())
                {
                    laws.Remove(l);
                }
            }
        }
        public void Establish(Party p)
        {
            bool found = false;
            foreach(Party pa in parties)
            {
                if(pa.name.Equals(p.name))
                {
                    found = true;
                }
            }
            if(found)
            {
                throw new ArgumentException();
            }
            parties.Add(p);
        }
        public bool AbstainParty()
        {
            foreach(Party p in parties)
            {
                if(p.cmen.Count() > 0)
                {
                    foreach(DraftLaw d in laws)
                    {
                        if(d.Abstain(p))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
