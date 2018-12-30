using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.Poly
{
    public class Technology:Hesap
    {
        public int amount = 2;
        public override string ProductName
        {
            get
            {
                return "TechnologyClass";
            }
        }

    }
}
