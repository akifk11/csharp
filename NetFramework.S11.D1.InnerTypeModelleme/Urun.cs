using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Tanim { get; set; }
        public decimal fiyat { get; set;}

        public Urun() {
            Console.WriteLine("Urun yapıcı metot çalıştı"); 
        }

        public void UrunTestMetot() {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
