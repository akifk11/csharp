using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1
{
    public class Ogrenci
    {
        public void selamlaOgrenci()
        {
            Console.WriteLine("Selamla Ogrenci");
        }

        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci bilgileri :{0} {1}", ogrenciAdi, ogrenciSoyadi);
        }
    }
}
