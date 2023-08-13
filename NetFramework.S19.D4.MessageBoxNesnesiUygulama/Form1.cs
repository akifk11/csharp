using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D4.MessageBoxNesnesiUygulama
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

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = yeniMusteriEkle(new Musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmail.Text,
                telefonNumarasi = txtTelefonNo.Text,
            });
            if (islemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("Musteri ekleme islemi basarili, yeni musteri kaydi eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam musteri kayit adedi" + sanalDatabase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Musteri adet bilgisi";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }else if(res == DialogResult.No)
                {

                }
                EkranTemizle();
                EkranListele();
            }
            else
            {
                MessageBox.Show("Hata: Kayıt ekleme islemi yapılamadı");
            }

        }

        private void EkranListele()
        {
            lstMusteriler.DataSource = sanalDatabase.musteriler;
        }

        private void EkranTemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefonNo.Text = string.Empty;
        }
        private int yeniMusteriEkle(Musteri data)
        {
            sanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
