using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan
{
    public class Competition
    {
        private int year;
        private string place;
        private HashSet<Category> cat = new HashSet<Category>();
        private List<Result> res = new List<Result>();
        private HashSet<Competitor> competitors = new HashSet<Competitor>();
        public Competition(int y, string p, List<Category> c)
        {
            if (c.Count == 0 || y <= 2000) { throw new Exception(); }
            year = y;
            place = p;
            foreach(Category e in c)
            {
                cat.Add(e);
            }
        }
        public void Register(Competitor c)
        {
            foreach(Competitor e in competitors)
            {
                if(e.ID() == c.ID())
                {
                    throw new Exception();
                }
            }
            competitors.Add(c);
            c.SetCompetition(this);
        }
        public Category PopularCat()
        {
            Category popularCat = cat.ElementAt(0);
            int maxNumRes = 0;

            foreach (var c in cat)
            {
                int currentNumRes = 0; // number of part for this competition type
                foreach(Result r in res)
                {
                    if(r.Cat().Type() == c.Type())
                    {
                        currentNumRes++;
                    }
                }
                if (currentNumRes > maxNumRes) { 
                    maxNumRes = currentNumRes;
                    popularCat = c;
                }
            }

            return popularCat;
        }
        public void Score(int min, int sec, int num, Category c)
        {
            bool l = false;
            Competitor elem = null;
            foreach (Competitor e in competitors)
            {
                if(e.ID() == num)
                {
                    l = true;
                    elem = e;
                }
            }
            if(!l) { throw new Exception(); }

            bool l2 = false;
            foreach(Category e in cat)
            {
                if(e == c) { l2 = true; }
            }
            if(!l2) { throw new Exception(); }

            bool l3 = false;
            foreach (Result e in res)
            {
                if (e.Cat() == c && e.Comp().ID() == num) { l3 = true; }
            }
            if(l3) { throw new Exception(); }

            res.Add(new Result(min, sec, elem, c));
        }
        public Tuple<bool, Competitor> Winner(Category c, bool man)
        {
            if(res.Count() == 0) { return new Tuple<bool, Competitor>(false, null); }

            bool l = false;
            Result elem = null;
            foreach(Result e in res)
            {
                if(!l && e.Cat() == c)
                {
                    elem = e;
                    l = true;
                }
                else if(l && e.Cat() == c && e.Comp().Man() == man)
                {
                    if (e.Min() * 60 + e.Sec() < elem.Min() * 60 + elem.Sec())
                    {
                        elem = e;
                        l = true;
                    }
                }
            }

            return new Tuple<bool, Competitor> (l, elem.Comp());
        }
    }
}
