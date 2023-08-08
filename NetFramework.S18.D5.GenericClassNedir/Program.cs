using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D5.GenericClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.TcKimlikNumarasi = "12345678946";
            M1.musteriNumara = "MS123";
            M1.isim = "Akif";
            M1.soyisim = "Kiraz";
            M1.DogumTarih = DateTime.Parse("02.11.1988");

            MusteriGeneric<int> musteriGeneric1 = new MusteriGeneric<int>();
            musteriGeneric1.id = 1;
            musteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid>musteriGeneric2 = new MusteriGeneric<Guid>();
            musteriGeneric2.musteriNumarasiAl();
        }
    }
}
