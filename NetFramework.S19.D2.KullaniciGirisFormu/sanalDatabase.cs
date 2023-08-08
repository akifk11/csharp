using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D2.KullaniciGirisFormu
{
    public class sanalDatabase
    {
        // generic bir ifade oluşturuyorum kullaniciyı temsil edecek
        public static List<kullanici> kullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            kullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "akif",
                soyisim = "kiraz",
                kullaniciAdi = "akif.kiraz",
                sifre = "1",
                aciklama = "akif kiraz kullanici profil bilgisi"
            });

            kullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "bahadir",
                soyisim = "kiraz",
                kullaniciAdi = "bahadir.kiraz",
                sifre = "2",
                aciklama = "bahadir kiraz kullanici profil bilgisi"
            });
        }
    }
}
