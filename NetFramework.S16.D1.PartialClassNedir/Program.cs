using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "akif";
            m1.soyisim = "kiraz";
            m1.emailAdres = "akf@hotmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc > 0)
            {
                Console.WriteLine("database'e yeni kayit eklendi");
            }

            ogrenci O1 = new ogrenci();
            O1.id = 1;
        }
    }
}
