using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static : nesne örneği alınmadan ulaşabildiğimiz metot , field , sınıf
            // tip M1 = new Tip() Bir nesne örneği


            // stack bölgede pointer oluştu
            Ogrenci O1;
            // stack bölgede pointer oluştuğu zaman static olan yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field,metot static dediğimiz bölgede oluşturuldu.
            Ogrenci.Test2();


            O1 = new Ogrenci();
            // stack bölgede oluşan pointer => kendisin heap bölgede tamamladı.. static olmayan tanımlarını tamamladı.
            O1.Test1(); // nesne örneği alındıktan sonra Test1() metotuma ulaşabildim.

            /* Static kavramı gerçak hayatta nerelerde kullanılır
             
            1 - Helper.cs => Kontrolller  
            2 - Oluşturduğumuz olduğumuz nesnemizin => bağımlılığı farklı classlara olduğu için 
            (proje içerisinde özel olduğu için) nesne içerisinde static metot tanımları yapılır
            3 - Class içerisinde bir field (static) tanımı yapar ilgili field içerisine bir değer ataması yaparız. 
            Daha sonra uygulama içerisinde en farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır değerimizi okuruz.
            4 - [ Uygulama ] => [ozelHelper] => [ DLL ]

             
             */

        }
    }
}
