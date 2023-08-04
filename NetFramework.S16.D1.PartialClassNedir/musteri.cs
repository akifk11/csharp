using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public class musteri // bu konu baslığında musteri classımızı parçalıyacaz
    {
        #region Fields
        public int id {  get; set; }
        public string isim { get; set; }    
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        #endregion

        #region Metot
        public int yeniKayit(musteri m) // musteri nesnesi alıyor
        {
            Console.WriteLine("database kayıt islemi tamamlandı");
            return 1;
        }
        public int kayitGuncelle(musteri m) // musteri nesnesi alıyor
        {
            Console.WriteLine("musteri kaydi guncellendi");
            return 1;
        }
        public int kayitSil(musteri m) // musteri nesnesi alıyor
        {
            Console.WriteLine("musteri kaydi silindi");
            return 1;
        }
        #endregion
    }
}
