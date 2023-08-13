namespace NetFramework.S19.D13.DataGridViewImage
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
            this.components = new System.ComponentModel.Container();
            this.grdUrunler = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunResimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUrunler
            // 
            this.grdUrunler.AllowUserToAddRows = false;
            this.grdUrunler.AllowUserToDeleteRows = false;
            this.grdUrunler.AutoGenerateColumns = false;
            this.grdUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunTanimDataGridViewTextBoxColumn,
            this.resimYolDataGridViewTextBoxColumn,
            this.urunResimDataGridViewImageColumn});
            this.grdUrunler.DataSource = this.urunBindingSource;
            this.grdUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUrunler.Location = new System.Drawing.Point(0, 0);
            this.grdUrunler.Name = "grdUrunler";
            this.grdUrunler.ReadOnly = true;
            this.grdUrunler.Size = new System.Drawing.Size(503, 466);
            this.grdUrunler.TabIndex = 0;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(NetFramework.S19.D13.DataGridViewImage.urun);
            // 
            // urunTanimDataGridViewTextBoxColumn
            // 
            this.urunTanimDataGridViewTextBoxColumn.DataPropertyName = "UrunTanim";
            this.urunTanimDataGridViewTextBoxColumn.HeaderText = "Ürün Tanım";
            this.urunTanimDataGridViewTextBoxColumn.Name = "urunTanimDataGridViewTextBoxColumn";
            this.urunTanimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunTanimDataGridViewTextBoxColumn.Width = 87;
            // 
            // resimYolDataGridViewTextBoxColumn
            // 
            this.resimYolDataGridViewTextBoxColumn.DataPropertyName = "ResimYol";
            this.resimYolDataGridViewTextBoxColumn.HeaderText = "ResimYol";
            this.resimYolDataGridViewTextBoxColumn.Name = "resimYolDataGridViewTextBoxColumn";
            this.resimYolDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimYolDataGridViewTextBoxColumn.Width = 76;
            // 
            // urunResimDataGridViewImageColumn
            // 
            this.urunResimDataGridViewImageColumn.DataPropertyName = "UrunResim";
            this.urunResimDataGridViewImageColumn.HeaderText = "UrunResim";
            this.urunResimDataGridViewImageColumn.Name = "urunResimDataGridViewImageColumn";
            this.urunResimDataGridViewImageColumn.ReadOnly = true;
            this.urunResimDataGridViewImageColumn.Width = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 466);
            this.Controls.Add(this.grdUrunler);
            this.Name = "Form1";
            this.Text = "DataGridView-Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTanimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn urunResimDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource urunBindingSource;
    }
}

