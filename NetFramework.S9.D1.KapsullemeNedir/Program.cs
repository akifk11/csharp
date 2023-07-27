using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.isim = "akif";
            // M1.soyisim = "kiraz";

            /*
             * Field değer ataması yapılamasın ama değer okunabilsin
             * Field içersine değer ataması yapılsın ama değer okunamasın
             * Field değer atamasının ama ilk 4 hanesi okunsun
             * Field okuma ve yazma yapılsın ama bir süreçten geçsin sonra gösterilsin
             */

            // Class
            // Field
            // Property
            // Get & Set

            // M1.emailAdres = "akif@hotmail.com"; (Field)

            // Genel kapsülleme
            // M1.EmailAdres = "akif@hotmail.com";
            Console.Write(M1.EmailAdres);

            // 1.Field değer ataması yapılamasın ama değer okunabilsin
            Console.WriteLine("Musteri Id Değeri" + M1.ID.ToString());
            // M1.ID = 10;

            M1.TCKimlikNumarasi = "78945612399";

            string TC = M1.TCKimlikNumarasi;
            Console.WriteLine("TC kimlik numarası:{0}", TC);

            // isim soyisim 
            // email adresi
            M1.isim = "akif";
            M1.Soyisim = "kiraz";

            Console.WriteLine(M1.EmailAdres);



            Console.ReadKey();

        }
    }
}
