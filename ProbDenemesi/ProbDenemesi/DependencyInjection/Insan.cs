using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.DependencyInjection
{
    public class Insan
    {
        IGiyin _giyin;
        public Insan(IGiyin giyin) 
        {
            _giyin = giyin;
        }

        public string yaz() 
        {
            return _giyin.Giyin();
        }
    }
}
