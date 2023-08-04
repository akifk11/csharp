using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D1.AbstractNedir
{
    public abstract class temelSinif // abstract ve interface örneklenemez sealed kalıtılmayı engeller
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public temelSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("temel sınıfın içerisindeki test metodu");
        }

        public abstract void testAbstract(); // abstract metot kalıtan diğer nesneler görebilir abstract metotların metot bodyleri yoktur sadece metot imzası vardır
        
    }
}
