using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi
{
    public interface IBasliklar
    {
        string Isim(); //Method
        string AnaBaslik();
        string Yazdir();
        string Marka { get; } // Property
    }
}
