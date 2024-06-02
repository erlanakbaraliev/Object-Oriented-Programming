using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class Contest
    {
        public string location;
        public List<Angler> anglers = new List<Angler> ();
        public Contest(string location) {
            this.location = location;
        }
        public void Register(Angler member)
        {
            anglers.Add(member);
        }
        public bool AllCatFish()
        {
            bool allCatFish = true;
            foreach (var e in anglers)
            {
                allCatFish = allCatFish && e.CatFish(this);
            }
            return allCatFish;
        }
        public float Point()
        {
            float sum = 0;
            foreach(var e in anglers)
            {
                sum += e.Points(this);
            }
            return sum;
        }
    }
}
