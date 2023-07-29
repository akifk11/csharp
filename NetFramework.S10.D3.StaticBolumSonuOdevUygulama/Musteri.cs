using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevUygulama
{
    public class Musteri
    {
        #region Sanal Database
        static ArrayList musteriDatabase; // sisteme ilk static düştüğü için static metot kullanıyoruz arraylist obje olarak değer tutar.
        #endregion

        #region Static Yapıcı Metot
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion

        #region Field
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        private string _kullaniciAdi;
        public string sifre { get; set; }
        #endregion
        #region Kapsulleme
        public string KullaniciAdi { 
            get { return _kullaniciAdi;}
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanici adi sistem içerisinde kayıtlı");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }
        #endregion

        #region Static Metotlar
        static bool musteriKullaniciAdiKontrol(string _kullaniciadi)
        {
            bool Kontrol = false;

            for(int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i]; // obje olarak dönüyor ama bunu biz bu şekilde kullanamıyoruz o yüzden özel tipimize dönüştürmemz lazım
                // Zorunlu Musteri tipine dönüştürüyoruz ve sadece burada kullanmak için Musteri Temp içine atıyoruz bu şekilde de kullanılabilir 
                // (Musteri)musteriDatabase[i].kullaniciAdi
                if (Temp.KullaniciAdi == _kullaniciadi)
                {
                    Kontrol = true;
                    break;
                }
            }

            return Kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            #region Parametre Kontrol
            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistemde kayıtlı");
                }
                else { 
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                        }

            }
            #endregion
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;
            for(int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i]; // obje olarak atama yapıyor
                if(Temp.emailAdres == _emailAdres)
                {
                    Kontrol |= true;
                    break;
                }
            }
            return Kontrol;
        }
        #endregion
    }
}
