using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MetotOdev1
{
    public class ogrenci
    {
        public void ogrenciNotHesapla(string ad,string soyad,decimal not1, decimal not2, decimal not3 = 45)
        {
            Console.WriteLine("Ogrencinin bilgileri asagidaki gibidir");
            Console.WriteLine("Ad Soyad:{0} {1}",ad,soyad);

            ortalamaDegerlendir(ortalamaHesapla(not1, not2, not3));
            
            
        }

        private void ortalamaDegerlendir(decimal ogrenciOrtalama)
        {
            if (ogrenciOrtalama < 45)
            {
                Console.WriteLine("Ortalama degeriniz:{0} - Kaldınız", ogrenciOrtalama);
            }
            else
            {
                Console.WriteLine("Ortalama degeriniz:{0} - Geçtiniz", ogrenciOrtalama);
            }
        }

        private decimal ortalamaHesapla(decimal Ogrnot1,decimal Ogrnot2, decimal Ogrnot3)
        {
            //decimal ortalama = (Ogrnot1 + Ogrnot2 + Ogrnot3) / 3;
            //return ortalama;
            return (Ogrnot1 + Ogrnot2 + Ogrnot3) / 3;
        }
    }
}
