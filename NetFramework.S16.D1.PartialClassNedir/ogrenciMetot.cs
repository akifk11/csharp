using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public partial class ogrenci  // partial ile birlikte ilgili classlarımızın birer parça olduğunu söylüyoruz
    {
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("kayit islemi basarili");
            return 1;
        }

        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("Ogrenci kayit guncelleme basarili");
            return 1;
        }

        public int kayitSil(int i)
        {
            Console.WriteLine("ogrenci silindi");
            return 1;
        }
    }
}
