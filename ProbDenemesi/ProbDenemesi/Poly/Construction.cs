using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.Poly
{
    public class Construction:Hesap
    {
        public int amount = 1;
        public override string ProductName
        {
            get
            {
                return "ConstructionClass";
            }
        }

        public override double CalculateVAT(double price)
        {
            price = price + price * 0.01;
            return price;
        }
    }
}
