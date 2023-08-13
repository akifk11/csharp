using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D6.FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Button => this.controls.Add(); // control ...
            //foreach (Control item in this.Controls)
            //{
            //    MessageBox.Show(item.Name);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult resultEnum = MessageBox.Show("Form içerisinde bulunan değerleri silmek istediğinize emin misiniz", "Form Temizleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultEnum == DialogResult.Yes)
            {
                //  formTemizle();
                formElemanIndexTemizle();
            }else
            {
                // işlem iptal edildi....
            }
        }

        private void formElemanIndexTemizle() // form üzerindeki elemanları temizleme işlemi
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefonNo"]).Text = string.Empty;
        }

        private void formTemizle() // form üzerindeki textboxları temizleme işlemi yapıyor
        {
            foreach (Control item in this.Controls)
            {
                 if(item is TextBox) // item control == Textbox
                {
                    TextBox T = (TextBox)item;
                    T.Text = String.Empty;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // sanal database içerisine kayıt işlemi olacak ..... (ödev)


            formTemizle();
        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit onizlemeKayit = new frmOnizlemeKayit();
            ((TextBox)onizlemeKayit.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)onizlemeKayit.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)onizlemeKayit.Controls["txtEmailAdres"]).Text = txtEmailAdres.Text;
            ((TextBox)onizlemeKayit.Controls["txtTelefonNo"]).Text = txtTelefonNo.Text;
            onizlemeKayit.ShowDialog();
            
        }
    }
}
