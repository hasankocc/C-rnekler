using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.DependencyInjection
{
    public class Hirka : IGiyin
    {
        public string Giyin()
        {
            return "Hava çok serin old için hırka giyin!";
        }
    }
}
