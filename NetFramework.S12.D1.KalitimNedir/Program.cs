using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // temelTip T1 = new temelTip();
           // T1.TemelTipMetot1();

           //Egitmen E1 = new Egitmen();
           //Console.WriteLine("Eğitmen nesnesi örneklendi");
           // E1.TemelTipMetot1();

           // // Özel tiplerde Boxing ve Unboxing

           // // Bizim object nesnemiz nedir?
           // // temelTip
           // temelTip T2; // temelTip obje mi aldım
           // // Hangi nesnelerde temelTip object görevi görür
           // // Personel Eğitimen öğrenci
           // // Temeltip nesnesinden türetildikleri için temeltip nesnesi bu nesnelerde object gibi davranır

           // T2 = E1; // Eğitmen nesnesini temeltip nesnesine atadık

           // E1 = (Egitmen)T2; // unboxing

           // Personel P1 = new Personel();

           // T2 = P1; // Personel nesnesini temeltip nesnesine atadık temeltip nesnesi yine obje olarak görev yaptı

           // P1 = (Personel)T2; // unboxing

           // Ogrenci O2 = new Ogrenci();

           // T2 = O2; // Ogrenci nesnesini temeltip nesnesine atadık temeltip nesnesi yine obje olarak görev yaptı

           // O2 = (Ogrenci)T2; // unboxing

           // object O3 = T2;

           // // Boxing -- Unboxing

           // //object O1 = E1;  //boxing
           // //E1 = (Egitmen)O1; // unboxing

           // // obje nesnesi burada diyorki herşey benden türediği için ben hepsini tanırım

            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object Obj1 = O1;
            //O1 = (Ogrenci)Obj1;

            //Obj1 = P1;
            //P1 = (Personel)Obj1;

            // Ben istiyorum ki türemiş olan tiplerim türeyemesin
            // object => temelTip => Personel => 
            //                    => Ogrenci => X
            //                    => Egitmen => X
            //Test T1 = new Test();
            //T1.

            // Hangi nesnemizin kalıtılmasını istemiyoruz ?
            // Egitmen sealed

            Egitmen E1 = new Egitmen();

            // Egitmen => Personel => Temeltip => Object
            // Object => TemelTip => Personel => Egitmen

            // public : uygulama içerisinde veya dışarısında heryerden erişilebilir anlamı taşır
            // private : sadece tanımlandığı class içerisinden erişilebilir
            // protected : Normal kullanımda private gibi davranır.Kalıtım durumlarında kullanılabilir.

            temelTip T1 = new temelTip();
            // T1.TemelTipMetot2(); protected olduğu için çağıramıyorum
        }
    }
}
