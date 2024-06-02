using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Normal : DraftLaw
    {
        public Normal(string d, string ID) : base(d, ID)
        {
        }
        public override bool IsValid()
        {
            return YesCount() * 2 > votes.Count();
        }
    }
}
