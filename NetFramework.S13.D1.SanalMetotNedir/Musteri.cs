using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    public class Musteri // standart olarak Framework tüm nesneleri objectten türetir
    {
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public override string ToString() // sanal metot
        {
           // return base.ToString(); // base şuan için namespace'i gösteriyor normalde kalıtıldığı class'ı gösterir
           return isim + " " + soyisim;
        }
    }
}
