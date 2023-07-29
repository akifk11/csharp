using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public static class Helper
    {
        //public Helper()
        //{
        //    // Her nesne örneği alındığında uygulama standart yapıcı metodu çalıştırır
        //}

        static Helper()
        {
            // Uygulama içerisinde istenildiği kadar çağırılsınlar sadece ilk çağırılmada çalışırlar....
            Console.WriteLine("Helper => Static class => static CTOR");
        }
        public static void emailGonder(string aliciEmailAdres,string konu, string icerik)
        {
            // Email gönderme işlemleri devam edecek
            Console.WriteLine("Email gönderme işlemi başarılı");
        }
    }
}
