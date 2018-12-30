using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi
{
    public interface IUzunluk
    {
        string En();
        string Boy();
        string Yazdir();
        double Fiyat { get; set; }
    }
}
