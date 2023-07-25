using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D4.RefOutKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ref ve Out anahtar sözcüklerinde eski .net framework sürümlerinde 1 fark vardı 
            // Mevct .Net sürümü 7 olanlar bundan etkilemiyecekler.

            //int sayi1 = 0;
            //degerAta(ref sayi1);

            topla(5, 9, 20, 45, 70);

            Console.ReadKey();

        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }

        static void topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam: {0}",toplam);
        }
        
    }
}
