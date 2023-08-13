namespace NetFramework.S19.D9.ListBoxInceleme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.pctUrunResim = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 12);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstUrunler.Size = new System.Drawing.Size(229, 329);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunAciklama);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtStokAdet);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.pctUrunResim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Ürün Detay Bilgisi";
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(7, 147);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(422, 163);
            this.txtUrunAciklama.TabIndex = 3;
            this.txtUrunAciklama.Text = "";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(226, 90);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(203, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(226, 64);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(203, 20);
            this.txtStokAdet.TabIndex = 2;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(226, 41);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(203, 20);
            this.txtKategori.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(226, 17);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(203, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // pctUrunResim
            // 
            this.pctUrunResim.Location = new System.Drawing.Point(7, 20);
            this.pctUrunResim.Name = "pctUrunResim";
            this.pctUrunResim.Size = new System.Drawing.Size(126, 120);
            this.pctUrunResim.TabIndex = 1;
            this.pctUrunResim.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstUrunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listbox İnceleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtUrunAciklama;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.PictureBox pctUrunResim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

