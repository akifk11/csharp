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
            YeniKlasorOlustur("C:\\Udemy");
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo D1 = Directory.CreateDirectory(path); // örnekleme yapmadan ulaşabildiğimiz için CreareaDirectory static metot demek

        }
    }
}
