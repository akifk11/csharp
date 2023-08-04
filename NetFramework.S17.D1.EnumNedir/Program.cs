using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri M1 = new musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "akif";
            M1.soyisim = "kiraz";
            M1.emailAdres = "akf@gmail.com";

            sanalDatabase SB = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            // int enumInt = musteriReturnValue.kayitBasarisiz; bu değerler aslında arka planda integer değere denk gelmekte

            if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {

            }
        }
    }
}
