﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D13.DataGridViewImage
{
    public class urun
    {
        public int id { get; set; }
        public string UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image UrunResim
        {
            get
            {
                if (!string.IsNullOrEmpty(ResimYol))
                {
                    return Image.FromFile(ResimYol);

                }
                else
                {
                    return Image.FromFile(@"C:\UrunGrid\noImage.jpg");
                }
            }
        }


    }
}
