using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNedir_1
{
    public class genericRepository<T>
    {
        public genericRepository()
        {
            // context :EF DBFirst
        }

        public virtual List<T> Getir()
        {
            // gelen T tipini database üzerinden sorgulamak elde etmiş olduğum kayıtları generic koleksiyon olarak bir 
            // bir üst katmana dönmek
            return null;
        }

        public virtual void yeniKayitEkle(T data)
        {
            // bize gelen T tipi içerisindeki bilgiyi tabloya ekliyoruz

        }
    }
}
