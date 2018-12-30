using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi
{
    class Degerler
    {
        private int Sayi1=0;
        private int Sayi2=0;
        private int wrongnumber = 10;
        public int righttoplamsonuc=0;
        public int wrongtoplamsonuc=0;
        private const string msjText = "İslem Basarili!";//Programın hiçbir yerinde değiştirilemeyen değer.

        protected int righttoplam() //Bulunduğu class ve ondan türetilen classlar kullanabilir
        {
            int sonuc;
            sonuc = Sayi1 + Sayi2;
            return sonuc;
        }

        private int wrongtoplam() //Sadece bulunduğu class 
        {
            int sonuc;
            sonuc = sayi1 + Sayi2;
            return sonuc;
        }

        public void totalsonuc() //Herkes erişebilir.
        {
            righttoplamsonuc = righttoplam();
            wrongtoplamsonuc = wrongtoplam();
        }

        public int sayi1 {//bu şekilde de kullanılabilir
            get 
            {
                return wrongnumber;
            }
            set 
            {
                Sayi1 = value;
            }
        }
        public int sayi2 //Doğru kullanım
        {
            get 
            {
                return Sayi2;
            }
            set 
            {
                Sayi2 = value;
            }
        }

    }
}
