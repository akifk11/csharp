using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D13.DataGridViewImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<urun> urunlerim = new List<urun>();
            urunlerim.Add(new urun()
            {
                id = 1,
                UrunTanim = "Tablet 1",
                ResimYol = @"C:UrunGrid\tablet1.jpg"
            });
            urunlerim.Add(new urun()
            {
                id = 2,
                UrunTanim = "Tablet 2",
                ResimYol = @"C:UrunGrid\tablet1.jpg"
            });
            urunlerim.Add(new urun()
            {
                id = 3,
                UrunTanim = "Tablet 3",
                ResimYol = @"C:UrunGrid\tablet1.jpg"
            });

            grdUrunler.DataSource = urunlerim;
        }
    }
}
