using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "akif";
            P1.Soyisim = "kiraz";
            P1.Emailadres = "akif.kiraz";
            P1.Cinsiyet = 717770001; // 717770002 - Bayan

            Personel P2 = new Personel();
            P2.Soyisim = "kiraz";
            P2.Emailadres = "akif.kiraz";
            P2.Cinsiyet = 717770001; // 717770002 - Bayan
            P2.Isim = "akif";

            Helper.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.Soyisim);

            // Helper H1 = new Helper(); Helper class'ımız static olduğu için nesnesini oluşturamam

            Console.ReadKey();
        }
    }
}
