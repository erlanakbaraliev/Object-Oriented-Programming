using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class Angler
    {
        public string Name { get; set; }
        List<Catch> catches = new List<Catch> ();
        public Angler(string name)
        {
            Name = name;
        }
        public void Catch(Fish f, float w, Contest c)
        {
            catches.Add(new Catch(f, w, c));
        }
        public float Points(Contest c)
        {
            float sum = 0;
            foreach(Catch e in catches)
            {
                if(e.contest == c)
                {
                    sum += e.Value();
                }
            }
            return sum;
        }
        public bool CatFish(Contest c)
        {
            bool found = false;
            foreach(Catch e in catches)
            {
                if(e.contest == c && e.fish.IsCatf()) {
                    found = true;
                }
            }
            return found;
        }
    }
}
