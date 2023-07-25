using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D5.AsiriYuklenmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine(true);

            // bu durum metot overloading oluyor
            //decimal toplam =topla(12M,29M);
            //EkrandaGoster(toplam);

            EkrandaGoster(topla(100, 11));

            Console.ReadKey();
        }

        static void EkrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }

        static string topla(string sayi1, string sayi2)
        {
            string toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
