using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public class Personel
    {
        public static string domainAdres;
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        private string _emailadres;
        public string Emailadres { get { return this._emailadres; } set { _emailadres = value.ToLower() + "@" + Personel.domainAdres; } }

        public int Cinsiyet { get; set; }

        public Personel() {
            Console.WriteLine("Her örneklemede çalısan metot");
        }
        static Personel() {
            domainAdres = "firmam.com";
            // öncelikle static yapıcı metot çalışır sonra normal yapıcı metot
        }
    }


}
