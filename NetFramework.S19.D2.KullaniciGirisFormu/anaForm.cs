﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D2.KullaniciGirisFormu
{
    public partial class anaForm : Form
    {
        public anaForm(kullanici bulunanKullanici)
        {
            InitializeComponent();
            txtIsim.Text = bulunanKullanici.isim;
            txtSoyisim.Text = bulunanKullanici.soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
            txtKullaniciAdi.Enabled = false;
            txtSifre.Text = bulunanKullanici.sifre;
            txtAciklama.Text = bulunanKullanici.aciklama;
            btnGuncelle.Tag = bulunanKullanici.id;

        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Button btnGuncelleYakala = (Button)sender;
            int id = (int)btnGuncelle.Tag;
            int index = sanalDatabase.kullaniciTablo.FindIndex(i => i.id == id);
            sanalDatabase.kullaniciTablo[index].isim = txtIsim.Text;
            sanalDatabase.kullaniciTablo[index].soyisim = txtSoyisim.Text;
            sanalDatabase.kullaniciTablo[index].sifre = txtSifre.Text;
            sanalDatabase.kullaniciTablo[index].aciklama = txtAciklama.Text;
        }
    }
}
