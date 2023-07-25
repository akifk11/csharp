using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Araç sınıfı İnceleme
            Arac A1 = new Arac("Opel","Corsa",2010,56000);
            A1.AlisFiyati = 28000;
            A1.SatisFiyati = 32000;
            A1.MaxIndirimTutar = 1500;
            // A1.Fiyat =  Kapsülleme Konusu
            A1.FiyatAta(30000);
            A1.BilgileriGoruntule();
            #endregion


            Musteri M1 = new Musteri("78945612378","murat");
            M1.TCkimliknumara = "12245684594";
            M1.isim = "akif";
            M1.soyisim = "kiraz";
            M1.cinsiyet = 717770001;

            Musteri M2 = M1;
            M2.isim = "murat";
            M1.TCkimliknumara = "12245684598";

            bool musteriKontrol = M1.MusteriKontrol();

            //M2 = null;
            //M1 = null; 

            //string isim = M2.isim;


        }
    }
}
