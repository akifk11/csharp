using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList(); // private özellik gösterir metotlarla erişim sağlayacağım

        public musteriReturnValue musteriYeniKayit(musteri M) // geri dönüşü enum yaptık
        {
            // parametre kontrol
            // kayıt kontrol 
            sanalDB.Add(M);
            return musteriReturnValue.kayitBasarili;
        }

    }
}
