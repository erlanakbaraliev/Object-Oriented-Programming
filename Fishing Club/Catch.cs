using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Club
{
    public class Catch
    {
        public Fish fish;
        public float weight;
        public Contest contest;
        
        public Catch(Fish f, float w ,Contest c)
        {
            this.fish = f;
            this.weight = w;
            this.contest = c;
        }
        public float Value()
        {
            return weight * fish.Mult();
        }
    }
}
