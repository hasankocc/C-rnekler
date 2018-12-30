using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.DependencyInjection
{
    public class Ceket : IGiyin
    {
        public string Giyin()
        {
            return "Hava sıcak old için ceket giyin!";
        }
    }
}
