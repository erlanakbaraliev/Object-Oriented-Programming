using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class Club
    {
        public List<Contest> contests = new List<Contest>();
        public HashSet<Angler> members = new HashSet<Angler>();
        public Contest Organize(string l)
        {
            Contest contest = new Contest(l);
            contests.Add(contest);
            return contest;
        }
        public void Join(Angler a)
        {
            members.Add(a);
        }
        public bool Best()
        {
            bool l = false;
            Contest maxContest = null;
            float maxPoint = 0.0F;
            foreach (Contest e in contests)
            {
                if (e.AllCatFish())
                {
                    if (!l)
                    {
                        l = true;
                        maxContest = e;
                        maxPoint = maxContest.Point();
                    }
                    else
                    {
                        if (e.Point() > maxPoint)
                        {
                            maxContest = e;
                            maxPoint = e.Point();
                        }
                    }
                }
            }
            if (l)
            {
                Console.WriteLine("The best contest: " + maxContest.location + " points: " + maxContest.Point());
            }
            return l;
        }
    }
}
