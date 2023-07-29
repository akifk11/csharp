using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "akif";
            M1.soyisim = "kiraz";
            M1.emailAdres = "akif.kiraz@hotmail.com";
            M1.KullaniciAdi = "cengiz.atilla";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "bahadir",
                soyisim = "kirazz",
                emailAdres = "bahadir.kiraz@hotmail.com",
                KullaniciAdi = "bahadir.kiraz",
                sifre = "2"

            };

            Musteri.MusteriEkle(M2);
        }
    }
}
