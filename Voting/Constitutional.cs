using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Constitutional : DraftLaw
    {
        public Constitutional(string d, string ID) : base(d, ID)
        {
        }
        public override bool IsValid()
        {
            if(parliament == null || parliament.cmen.Count() == 0)
            {
                return false;
            }
            return YesCount() * 3 >= parliament.cmen.Count() * 2;
        }
    }
}
