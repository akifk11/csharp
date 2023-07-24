using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MetotOdev1
{
    public class ogrenci
    {
        public void ogrenciNotHesapla(string ad,string soyad,decimal not1, decimal not2, decimal not3)
        {
            Console.WriteLine("Ogrencinin bilgileri asagidaki gibidir");
            Console.WriteLine("Ad Soyad:{0} {1}",ad,soyad);
            decimal ortalama = not1 + not2 + not3 / 3;
            
            if (ortalama < 45)
            {
                Console.WriteLine("Ortalama degeriniz:{0} - Kaldınız", ortalama);
            }
            else
            {
                Console.WriteLine("Ortalama degeriniz:{0} - Geçtiniz", ortalama);
            }
        }
    }
}
