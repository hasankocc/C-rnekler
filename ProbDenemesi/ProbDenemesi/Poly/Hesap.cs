using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi.Poly
{
    public abstract class Hesap
    {
        public virtual string ProductName { get; set; }
        public virtual double CalculateVAT(double price) 
        {
            price = price + price * 0.18;
            return price;
        }

        public double TotalPrice(double price, int amount) 
        {
            return (price * amount);
        }
    }
}
