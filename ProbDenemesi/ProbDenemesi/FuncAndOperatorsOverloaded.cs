using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbDenemesi;

namespace ProbDenemesi
{
    class FuncAndOperatorsOverloaded
    {
        public double ComputeVAT(double price,Enums.KDVTag category) 
        {
            double result = 0;
            switch (category) 
            {
                case Enums.KDVTag.Construction:
                    result = result +(price * 0.01) +price;
                    break;
                case Enums.KDVTag.Food:
                case Enums.KDVTag.Textile:
                    result = result +(price * 0.08) +price;                   
                    break;
                case Enums.KDVTag.Technology:
                    result = result + (price * 0.18) + price;
                    break;
            }
            return result;
        }

        public double ComputeVAT(double price, double rate) 
        {
            double result = 0;
            result = result + (price * rate) + price;
            return result;
        }
    }
}
