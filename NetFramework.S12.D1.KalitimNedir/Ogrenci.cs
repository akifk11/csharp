﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class Ogrenci:temelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }
        
        public Ogrenci() 
        {
            Console.WriteLine("Ogrenci nesnesi çalıştı");
        
        }
    }
}
