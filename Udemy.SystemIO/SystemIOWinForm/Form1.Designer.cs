namespace SystemIOWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPersonel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Liste";
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.Location = new System.Drawing.Point(7, 20);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(187, 316);
            this.lstPersonel.TabIndex = 0;
            this.lstPersonel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPersonel_MouseDoubleClick);
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(12, 365);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(200, 42);
            this.btnPersonelGetir.TabIndex = 1;
            this.btnPersonelGetir.Text = "Personel Getir";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            this.btnPersonelGetir.Click += new System.EventHandler(this.btnPersonelGetir_Click);
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(12, 413);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(200, 34);
            this.btnPersonelKaydet.TabIndex = 2;
            this.btnPersonelKaydet.Text = "Personel Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUlke);
            this.groupBox2.Controls.Add(this.txtFirma);
            this.groupBox2.Controls.Add(this.txtSoyisim);
            this.groupBox2.Controls.Add(this.txtEmailAdres);
            this.groupBox2.Controls.Add(this.txtIsim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Detay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(129, 53);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(194, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(129, 76);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(194, 20);
            this.txtSoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firma";
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Location = new System.Drawing.Point(129, 99);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(194, 20);
            this.txtEmailAdres.TabIndex = 1;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(129, 122);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(194, 20);
            this.txtFirma.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ulke";
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(126, 144);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(194, 20);
            this.txtUlke.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "System IO Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

