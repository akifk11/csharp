using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            kullanici bulunanKullanici = sanalDatabase.kullaniciTablo.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);

            // kullaniciAdi == "admin" && sifre == "123"
            if (bulunanKullanici != null)
            {
                anaForm _anaform = new anaForm(bulunanKullanici);
                _anaform.Show();
            }
            else
            {
                // windows form içerisinde kullanıcıya nasıl bir pop-up gösteririz
                MessageBox.Show("Hatalı kullanıcı bilgileri","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            // object sender üzerine tıklanan textbox'ın referansı ile geliyor
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
