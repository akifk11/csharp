using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D3.ListGenericInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] eklenecekData1 = new int[5]; // Bir dizi oluşturuyorum
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;
            eklenecekData1[4] = 6;


            // 1.yol ama uzun yol

            //for (int i = 0; i < eklenecekData1.Length; i++)
            //{
            //    sayilarim.Add(i);
            //}

            // 2.yol 
            sayilarim.AddRange(eklenecekData1); // bütün bir diziyi alabiliyor

            // -----------------------------------------------------------------

            int capacity = sayilarim.Capacity; // listgeneric bellekte 4 4 ekleme yapılır 
            int count = sayilarim.Count;

            sayilarim.TrimExcess(); // bu metot count ve capacity değerlerine eşitler

            // Soru ? : sayilarim koleksiyonu içerisindeki datayı yazdırmak istiyorum bunu nasıl yaparsınız

            sayilarim.ForEach(i => Console.WriteLine(i));
            // ilgili koleksiyon içerisinde arama yap!
            // => linq konusu list<T> içerisinde

            int bulunanDeger = sayilarim[3];

            Console.WriteLine("List<T> koleksiyonu içerisinde 3.indekste bulunan değer: {0}", bulunanDeger);

            sayilarim.Insert(3,100); // indeksleri kaydırarak ekleme yapar

            sayilarim.Any();

            bool kontrol1 = sayilarim.Any();
            bool kontrol2 = sayilarim.Any(i=>i>5); // 5 ten büyük değer varsa true döner

            sayilarim.Sort(); // A-Z 1-N
            sayilarim.Reverse();

            int enYuksekDeger = sayilarim.Max();
            int enDusukDeger = sayilarim.Min();
            int toplamDeger = sayilarim.Sum();

            // Uygulama alanı
            // List<T> Uygulama - Windows Form

            bool silmeIslemiSonuc = sayilarim.Remove(100);
            int silinenAdet = sayilarim.RemoveAll(i=> i>3); // belirtmiş olduğumuz kritere göre değerleri siler
            sayilarim.RemoveAt(2); // indekse göre silme yapar

            sayilarim.Clear(); // Bütün değerleri siler
        }
    }
}
