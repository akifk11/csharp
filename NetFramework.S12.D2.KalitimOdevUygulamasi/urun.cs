using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    public class urun : baseClass
    {
        public string marka { get; set; } //* belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin
        public string model { get; set; }
        private decimal _alisfiyati;
        public decimal alisfiyati
        {
            get { return _alisfiyati; }
            set
            {
                if (value <= 0) { Console.WriteLine("Alis fiyati sifirdan kucuk veya esit"); }
                else { _alisfiyati = value; }
            }
        } // 0 dan küçük olamaz
        private decimal _satisfiyati;
        public decimal satisfiyati
        {
            get { return _satisfiyati; }
            set
            {
                if (value < _alisfiyati)
                {
                    Console.WriteLine("Ürünün satış fiyatı alış fiyatından küçük olamaz");
                }else { _satisfiyati = value; }
            }
        } // alisfiyatindan kucuk olamaz 
        private decimal _kampanyaFiyat;

        public decimal kampanyaFiyat
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyati 0'a esit veya kucuk olamaz");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        } // kampanya fiyat degeri 0 den kucuk olamaz
    }
}
