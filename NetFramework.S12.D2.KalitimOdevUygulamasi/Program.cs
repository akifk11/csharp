using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            // B1.id = 1; // girmek istemiyorum, uygulamanın bu alanı set edilebilir şekilde bırakmakta istemiyorum
            B1.marka = "Lenova";
            B1.model = "z50";
            B1.islemci = "I5";
            B1.alisfiyati = 1000;
            B1.satisfiyati = 1500;
            B1.kampanyaFiyat = 1000;
            B1.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B1);


            bilgisayar B2 = new bilgisayar();
            // B1.id = 1; // girmek istemiyorum, uygulamanın bu alanı set edilebilir şekilde bırakmakta istemiyorum
            B2.marka = "Lenova";
            B2.model = "z50";
            B2.islemci = "I5";
            B2.alisfiyati = 1000;
            B2.satisfiyati = 1500;
            B2.kampanyaFiyat = 1000;
            B2.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B2);
        }
    }
}
