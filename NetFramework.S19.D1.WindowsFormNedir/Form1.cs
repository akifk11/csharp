﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D1.WindowsFormNedir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMesaj.Text = "Metin giriniz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            string txtMesajDegeri = txtMesaj.Text;
            MerhabaForm merhabaForm = new MerhabaForm(txtMesajDegeri);
            merhabaForm.Show();
        }

        private void txtMesaj_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
        }
    }
}
