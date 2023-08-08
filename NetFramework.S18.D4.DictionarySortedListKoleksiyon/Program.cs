using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D4.DictionarySortedListKoleksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic olmayan koleksiyon davranışı
            Hashtable HTList = new Hashtable();
            HTList.Add(1,"Bir");
            HTList.Add(2, "Iki");
            HTList.Add(3, true);

          

            // Dictionary<Tkey,TValue>
            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "Iki");
            DictionaryList.Add(3, "Uc");

            bool silmeSonuc = DictionaryList.Remove(1);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Alınan değer liste içerisinde bulunamadı");
            }

            bool arananDegerSonuc= DictionaryList.ContainsKey(1);
            bool arananDegerSonuc2 = DictionaryList.ContainsValue("Uc");

            string gelenDeger = DictionaryList[3];
            gelenDeger = "Yenilenen değer";
            DictionaryList[1] = gelenDeger;

            if (arananDegerSonuc2)
            {
                Console.WriteLine("Aranan değer bulundu");

            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı");
            }

            foreach (KeyValuePair<int,string> item in DictionaryList)
            {
                Console.WriteLine("Anahtar : {0} || Deger : {1}", item.Key, item.Value);
            }

            // DictionaryList'in tamamını siler DictioneyList.Clear();

            // SortedList koleksiyonu Dictionary'nin aynısıdır.
            SortedList<int,string> sortedListKoleksiyon = new SortedList<int,string>();
            sortedListKoleksiyon.Add(100, "Yüz");
            sortedListKoleksiyon.Add(50,"Elli");
            sortedListKoleksiyon.Add(1, "Bir");
            sortedListKoleksiyon.Add(1000, "Bin");
        }
    }
}
