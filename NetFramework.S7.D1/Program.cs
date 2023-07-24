using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba akif");
            //Selamla();

            Ogrenci O1 = new Ogrenci();
            O1.OgrenciMetot1("akif","kiraz");

            // O1.selamlaOgrenci();
            Console.ReadKey();
        }

        //static void Selamla() 
        //{
        //    Console.WriteLine("Greeting!!!!!");
        //}
    }
}
