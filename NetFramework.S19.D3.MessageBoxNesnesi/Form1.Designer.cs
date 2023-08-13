namespace NetFramework.S19.D3.MessageBoxNesnesi
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
            this.btnMesajGoster = new System.Windows.Forms.Button();
            this.btnSoruSor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesajGoster
            // 
            this.btnMesajGoster.Location = new System.Drawing.Point(12, 12);
            this.btnMesajGoster.Name = "btnMesajGoster";
            this.btnMesajGoster.Size = new System.Drawing.Size(105, 36);
            this.btnMesajGoster.TabIndex = 0;
            this.btnMesajGoster.Text = "Mesaj Göster";
            this.btnMesajGoster.UseVisualStyleBackColor = true;
            this.btnMesajGoster.Click += new System.EventHandler(this.btnMesajGoster_Click);
            // 
            // btnSoruSor
            // 
            this.btnSoruSor.Location = new System.Drawing.Point(123, 12);
            this.btnSoruSor.Name = "btnSoruSor";
            this.btnSoruSor.Size = new System.Drawing.Size(109, 36);
            this.btnSoruSor.TabIndex = 1;
            this.btnSoruSor.Text = "Soru Sor";
            this.btnSoruSor.UseVisualStyleBackColor = true;
            this.btnSoruSor.Click += new System.EventHandler(this.btnSoruSor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoruSor);
            this.Controls.Add(this.btnMesajGoster);
            this.Name = "Form1";
            this.Text = "Message Box Nesnesi İnceleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesajGoster;
        private System.Windows.Forms.Button btnSoruSor;
    }
}

