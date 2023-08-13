using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D7.DinamikFormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 1; i <= 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    btnTemp.Tag = true;
                    int mayinInt = int.Parse(lblMayin.Text);
                    mayinInt++;
                    lblMayin.Text = mayinInt.ToString();
                }
                else
                {
                    btnTemp.Tag = false;
                    int skorInt = int.Parse(lblSkor.Text);
                    skorInt++;
                    lblSkor.Text = skorInt.ToString();
                }
                btnTemp.Click += btnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }
        private void btnTemp_Click(object sender, EventArgs e)
        {
            Button basilanButon = ((Button)sender);
            bool mayinBulundumu = (bool)basilanButon.Tag;
            if (mayinBulundumu)
            {
                MessageBox.Show("Mayını buldunuz tebrikler");
                basilanButon.BackColor = Color.Red;
            }
            else
            {
                basilanButon.BackColor = Color.Green;
            }
        }
    }
}

//this.btnTemp.Location = new System.Drawing.Point(3, 3);
//this.btnTemp.Name = "btnTemp";
//this.btnTemp.Size = new System.Drawing.Size(35, 35);
//this.btnTemp.TabIndex = 0;
//this.btnTemp.Text = "1";
//this.btnTemp.UseVisualStyleBackColor = true;
