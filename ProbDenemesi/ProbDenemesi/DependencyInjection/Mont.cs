using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.DependencyInjection
{
    public class Mont : IGiyin
    {
        public string Giyin() 
        {
            return "Hava çok soğuk old için mont giyin!";
        }
    }
}
