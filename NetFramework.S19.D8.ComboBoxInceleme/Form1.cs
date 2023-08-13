using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D8.ComboBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Items.Add metodu kullanılarak değerler combobox'a eklendi...
            // comboBoxDoldurV1();
            comboBoxDoldurV2();
        }
        void comboBoxDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                 cmbUrunListe.Items.Add(item);
            }
        }
        void comboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = database.UrunTablo;
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1.Yontem
            // Secili item'ı obje olarak direk elde etme
            object o1 = cmbUrunListe.SelectedItem;
            urun u1 = (urun)o1; // cast işlemi yapıyorum

            // daha kısa yazma şekli
            // u1 = cmbUrunListe.SelectedItem == null ? null: cmbUrunListe.SelectedItem as urun;

            // 2.Yontem

            // ComboBox secilenCombobox = sender as ComboBox;

            // 1.Yontem eğer form içerisinde form elemanına özel bir metot yazıldıysa o zaman
            // ilgili form elemanını direk çağırmak daha mantıklıdır

            // 2.Yontem çalışma zamanı oluşturduğumuz form elemanlarından hangisine tıklandığını bilmediğimiz için ve metotumuz birden 
            // fazla form elemanında olay metodu olarak tanımlandığı için biz sender üzerinden gelen nesneyi kullanır kullanıcının 
            // hangi windows form elemanında işlem yaptığını anlarız (daha komplex yapılarda kullanırız.)

            // EventArgs e bize ilgili işlemin ne olduğunu söyler

            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtUrunAciklama.Text = u1.aciklama;

        }
    }
}
