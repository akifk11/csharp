﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalitimOdevUygulamasi
{
    public class baseClass
    {
        public static int sayac = 1; // ilk oluştuğu zaman 1 değerini otomatik olarak alsın

        public baseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                // bir sayac içerisindeki değerden faydalanmak istiyoruz
                //_id = sayac;
                //sayac = sayac + 1;
                // nedeni set alanı private olarak işaretlendi o yüzden sayaç değeri atanamıyor
            }
        } //*
        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                bool kontrolIslemi = sanalDatabase.dbBarkodKontrol(value);
                if (!kontrolIslemi)
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Bu barkod degeri mevcut");
                }
            }
        }
        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }

    }
}
// ctrl + k + d