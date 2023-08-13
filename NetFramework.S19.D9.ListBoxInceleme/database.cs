using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D9.ListBoxInceleme
{
    public class database
    {
        public static List<urun> UrunTablo = new List<urun>()
        {
            new urun() {id =1, urunAdi="Bir Ömür Nasıl Yaşanır",stokAdet=10,urunKategori="Roman",aciklama=@".....................",yazar="İlber Ortaylı",urunResim= @"C:\\Users\\akifk\\OneDrive\\Belgeler\\GitHub\\csharp\\NetFramework.S19.D8.ComboBoxInceleme\\Resimler\1.jpg"},
            new urun() {id= 2,urunAdi="Metastaz",stokAdet = 10,urunKategori="Roman",aciklama="************************************",yazar="Barış Pehlivan",urunResim =@"C:\\Users\\akifk\\OneDrive\\Belgeler\\GitHub\\csharp\\NetFramework.S19.D8.ComboBoxInceleme\\Resimler\2.jpg"},
            new urun() {id= 3,urunAdi="Şeker Portakalı",stokAdet = 10,urunKategori="Roman",aciklama="************************************",yazar="Barış Pehlivan",urunResim =@"C:\\Users\\akifk\\OneDrive\\Belgeler\\GitHub\\csharp\\NetFramework.S19.D8.ComboBoxInceleme\\Resimler\3.jpg"},
        };
    }
}
