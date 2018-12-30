using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDenemesi
{
    // Durağan üyelere ulaşmak için nesne oluşturulmasına yani nesne örneğine gerek yoktur ve bu üyelere sınıf ismi ile erişilir
    class StaticClass
    {
        public static int count;
        private int a;
        private double b;
        static StaticClass() // durağan yapıcılarda durağan değerler initialize edilir.
        {
          count=1;
        }
        StaticClass() // bütün tipteki değerler initialize edilir.
        {
            a = 0;
            b = 10;
        }
        private int topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public static void StaticMethod() 
        {
            int deger = 0;
            StaticClass denemeclass = new StaticClass(); // private constructor tanımlamama rağmen nesne oluşturmama izin verdi.
            deger = denemeclass.topla(3, 5);             // Bunun nedeni kendi classının içerisinde böyle bir kısıtlama yoktur.Erişim vardır.
            Console.WriteLine(deger);
        }
        public int carp(int sayi1 , int sayi2) 
        {
           int sonuc = 0;
           StaticClass denemeclass = new StaticClass();// Çünkü kendi class içi private değişkenlere dahi erişilebilir
           sonuc = denemeclass.topla(sayi1,sayi2);     // Class kendi içerisinde tüm fonksiyonların içinde yeni nesne oluşturulabilir.
           StaticClass.count++;                        //Normal fonksiyonların içerisinde hem statik hem de normal değerler yazılabilir.
           sonuc = sayi1 * sonuc;
           return sonuc; 
        }
        public static int cikarma(int sayi1,int sayi2) 
        {
            int sonuc = 0;
            StaticClass deneme = new StaticClass(); //Eğer nesne oluşturmuş isek statik olmayan fonksiyonlara ve alanlara erişebiliriz.
            sonuc = sayi1 - sayi2;                  //Fakat nesne oluşturmamış isek statik olan fonksiyon ve alanlara erişebiliriz. 
            //sonuc = sayi1 - a;                    //Static fonksiyonların içinde statik değerler kullanılır.
            return sonuc;                           
        }
        public static int bol(int sayi1, int sayi2) 
        {
            int sonuc=0;
            StaticClass deneme = new StaticClass();
            //sonuc = this.cikarma(sayi1,sayi2);//statikde geçerli değildir. (this)
            return sonuc;
        }
        public void thisdeneme() 
        {
            double sonuc = 0;
            sonuc = this.a + this.b;//this normal fonksiyonlarda kullanılır.statik üyelerde çalışmaz.Çünkü stackdeki tanımlanmamış 
                                    //nesnenin adresini gösterir. new keywordü ile tanımlandı mı esas nesne heap de saklanır.
                                    //Statik üyeleri göstermez
        }
    }
}
