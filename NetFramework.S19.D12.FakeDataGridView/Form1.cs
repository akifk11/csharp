using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D12.FakeDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim = FakeData.NameData.GetFirstName();
            //string soyisim = FakeData.NameData.GetSurname();
            //MessageBox.Show(isim + " " + soyisim , "Fakedata inceleme", MessageBoxButtons.OK);
            database db = new database();
            List<musteri> musteriListe = db.musteriListele();

            // 1. Data bize lazım ama ekranda göstermek istemiyoruz, bu gibi durumlarda columns koleksiyonuna ilgili kolınun id değeri 
            // veya tip prop adı verilerek Visiable prop false edilmesi yeterlidir.
            dgwMusteriListe.DataSource = musteriListe;
            //dgwMusteriListe.Columns[0].Visible = false;
            // dgwMusteriListe.Columns["id"].Visible = false;

            // dataGridView içerisinde bulunan kolonların isimlerini değiştirmek
            dgwMusteriListe.Columns[0].HeaderText = "Müşteri ID";
            dgwMusteriListe.Columns[1].HeaderText = "Müşteri İsim";
            dgwMusteriListe.Columns[2].HeaderText = "Müşteri Soyisim";
            dgwMusteriListe.Columns[3].HeaderText = "Müşteri Tam Adı";


            // 2. Data bize lazım değil hiçbir şekilde ekranda görülmesini veya kullanmak istemiyoruz

            //var dgwListe = from I in musteriListe
            //               select new
            //               {
            //                   isim = I.isim,
            //                   soyisim = I.soyisim,
            //                   tamAdi = I.tamAdi,

            //               };
            //dgwMusteriListe.DataSource = dgwListe.ToList();
        }

        private void dgwMusteriListe_DoubleClick(object sender, EventArgs e)
        {
          int musteriID  = (int)dgwMusteriListe[0, dgwMusteriListe.CurrentCell.RowIndex].Value;
          

            database db = new database();
            musteri bulunanMusteri = db.musteriListele().FindAll(i => i.id == musteriID).FirstOrDefault();

            popupMesaj popup = new popupMesaj(bulunanMusteri);
            popup.Show();   

        }
    }
}
