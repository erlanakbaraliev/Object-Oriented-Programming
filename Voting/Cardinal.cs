using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Cardinal : DraftLaw
    {
        public Cardinal(string d, string ID) : base(d, ID)
        {
        }
        public override bool IsValid()
        {
            if(parliament == null)
            {
                return false;
            }
            return YesCount() * 2 > parliament.cmen.Count();
        }
    }
}
