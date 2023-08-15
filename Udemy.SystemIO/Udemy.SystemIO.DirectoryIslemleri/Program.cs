using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; // sabit disk üzerinde klasör işlemleri yapmamıza yarıyor
using System.Text;
using System.Threading.Tasks;

namespace Udemy.SystemIO.DirectoryIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // YeniKlasorOlustur("C:\\Udemy");
            // KlasorVarlikKontrolu("C:\\Udemy");
            //  KlasorSilmeIslemleri("C:\\Udemy");
            KlasorTasima("c:\\Udemy","c:\\TasimaIslemi\\Udemy");
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo D1 = Directory.CreateDirectory(path); // örnekleme yapmadan ulaşabildiğimiz için CreareaDirectory static metot demek
        }

        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path);
        }

        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path,true); // içerisi doluysa eğer ikinci parametre girişi yaparız
        }

        static void Odev1()
        {
            /*
             * C sürücüsü içerisine Udemy adında bir klasör oluşturun oluşturmadan önce varlık kontrolü yapın kalsör var ise silin daha sonra 
             * oluşturun eğer klasör yok ise yine oluşturun fakat bu adımların bilgisini ekrana yazdırın
             * 
             */
            string dosyaYol = @"c:\\Udemy";
            bool kontrol = Directory.Exists(dosyaYol);
            if(kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör mevcut");
                Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz?");
                string cevap = Console.ReadLine().ToUpper();
                if(cevap == "E")
                {
                    Directory.Delete(dosyaYol,true);
                    Console.WriteLine("Dosya silme işlemi tamamlandi");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor");
                    Directory.CreateDirectory(dosyaYol);
                }
                else
                {
                    Console.WriteLine("Islem bitti");
                }
            }
            else
            {
                DirectoryInfo D2 = Directory.CreateDirectory(dosyaYol);
                if (D2.Exists)
                {
                    Console.WriteLine("Dosya sistemde oluşturuldu");
                }

            }

        }

        static void KlasorTasima(string kaynak,string hedef)
        {
            Directory.Move(kaynak,hedef);
        }
    }
}
