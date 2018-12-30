using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi
{
    class InterfaceKullananClass:IBasliklar,IUzunluk
    {
        private string marka = "Samsung";
        private double fiyat =3000;
        private double fiyat1 = 0;
        #region IBasliklar Members
        public string Isim() 
        {
            return "Galaxy Note 3";
        }
        public string AnaBaslik() 
        {
            return "teknoloji";
        }
        string IBasliklar.Yazdir() // İmplemente edilen iki interfacede de aynı isimde function varsa public olmasına izin verilmiyor çünkü karışıklığa neden oluyor.
        {
            return "Muhteşem Bir Ürün";
        }
        public string Marka 
        {
            get 
            {
                return marka;
            }
        }
        #endregion
        
        #region IUzunluk Members
        public string En() 
        {
            return "80.9mm";
        }
        public string Boy() 
        {
            return "160.6mm";
        }
        string IUzunluk.Yazdir() // İmplemente edilen iki interfacede de aynı isimde function varsa public olmasına izin verilmiyor çünkü karışıklığa neden oluyor.
        {
            return "Harika Bir Ürün";        
        }
        public double Fiyat 
        {
            get 
            {
                if(fiyat1 == 0)
                return fiyat;
                return fiyat1;
            }
            set 
            {
                fiyat1 = value;
            }
        }
        #endregion
    }
}
