using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "12345678946";
            M1.isim = "Akif";
            M1.soyisim = "Kiraz";
            M1.olusturmaTarihi = DateTime.Now;

            // M1.musteriAdresleri = new MusteriAdres[5];
            // Asla yapmayın oop deki yeri burası değil

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "Istanbul",
                Ilce = "Uskudar",
                Adres = "Adres...",
                adresTip = "İş yeri"
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SI0001",
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                UrunId = 1,
                Tanim = "Telefon",
                fiyat = 1500
            };
        }
    }
}
