using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bütün nesneler objectten türer
            // Object => ToString();
            // Musteri M1 = new Musteri();
            // Musteri nesnem Object nesnesinden kalıtılıyor
            //  M1.toString() toString() methodu kalıtımlar Objectten kalıtılıyor

            // Namespace.Musteri

            Musteri M1 = new Musteri();
            M1.isim = "akif";
            M1.soyisim = "kiraz";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj); // Çıktı:NetFramework.S13.D1.SanalMetotNedir.Musteri


        }
    }
}
