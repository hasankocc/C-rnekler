using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.Poly
{
    public class Food:Hesap
    {
        public int amount = 3;
        public override string ProductName
        {
            get
            {
                return "FoodClass";
            }
        }
        public override double CalculateVAT(double price)
        {
            price = price + price * 0.08;
            return price;
        }
    }
}
