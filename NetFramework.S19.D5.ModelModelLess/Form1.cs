﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D5.ModelModelLess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        { 
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();
            // arkadaki formda hala işlem yapabiliriz 
        }

        private void btnGosterPopup_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.ShowDialog();
            // yeni olusturulan formdaki işlem bitmediği sürece arkadaki formda işlem yapmaya izin vermez
        }
    }
}
