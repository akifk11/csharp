using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsullemeNedir
{
    public class Musteri
    {

        public Musteri() {
            this.id = IDUret();
        }
        // Class => Field
        private int id;
        public int ID { get 
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }
        public string isim;
        private string _soyisim;
        public string Soyisim
        {
            get { return this._soyisim; }
            set { this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@hotmail.com",isim,_soyisim);
            }
        }




        // Class => property
        private string emailAdres;
        public string EmailAdres
        {
            // get; // database veya farklı bir veri kaynağı ..class çağıran programcıya datayı gösterdiğimiz kısım
            // set; // dış dünyadan alınan datanın içeride private olarak saklanan Field içerisine atadığımız kısım

            private set
            {
               this.emailAdres = value; 
            }
            get
            {
                return this.emailAdres;
            }
        }

        // Ara ödev 
        private string _tckimliknumarasi;
        public string TCKimlikNumarasi
        {
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for(int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            // sayısal değer demektir
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }

                        
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("TC kimlik numarası içerisindeki değerler sayısal olmalıdır");
                    }
                    else { this._tckimliknumarasi = value; }
                }
            }
            get {
                return this._tckimliknumarasi.Substring(0,3); 
            }
        }

        private int IDUret()
        {
            Random Rnd = new Random();
            return Rnd.Next(10000,90000);
        }
    }
}
