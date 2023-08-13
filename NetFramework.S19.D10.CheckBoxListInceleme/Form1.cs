using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D10.CheckBoxListInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedBoxListDoldurV1();
        }

        private void checkedBoxListDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkListBox = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                urun secilenUrun = checkListBox.Items[e.Index] as urun; // e.Index bana ürün indexi verecek
                pctUrunResim.Image = Image.FromFile(secilenUrun.urunResim);
                txtUrunAdi.Text = secilenUrun.urunAdi;
                txtKategori.Text = secilenUrun.urunKategori;
                txtStokAdet.Text = secilenUrun.stokAdet.ToString();
                txtUrunAciklama.Text = secilenUrun.aciklama;
                txtYazar.Text = secilenUrun.yazar;
            }

            for (int i = 0; i < checkListBox.Items.Count; i++) {
                if (i == e.Index)
                {
                    // üzerinde bulunulan kayıt burası
                }
                else
                {
                    chkListBox.SetItemChecked(i, false);
                }

            }

        }
    }
}
