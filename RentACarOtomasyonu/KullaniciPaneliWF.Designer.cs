namespace RentACarOtomasyonu
{
    partial class KullaniciPaneliWF
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
            this.btn_kp_sözlesme = new System.Windows.Forms.Button();
            this.btn_kp_musteri = new System.Windows.Forms.Button();
            this.btn_kp_arac = new System.Windows.Forms.Button();
            this.btn_kp_silinenler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kp_sözlesme
            // 
            this.btn_kp_sözlesme.Location = new System.Drawing.Point(23, 161);
            this.btn_kp_sözlesme.Name = "btn_kp_sözlesme";
            this.btn_kp_sözlesme.Size = new System.Drawing.Size(224, 48);
            this.btn_kp_sözlesme.TabIndex = 0;
            this.btn_kp_sözlesme.Text = "SÖZLEŞME EKLE/DÜZENLE";
            this.btn_kp_sözlesme.UseVisualStyleBackColor = true;
            this.btn_kp_sözlesme.Click += new System.EventHandler(this.btn_kp_sözlesme_Click);
            // 
            // btn_kp_musteri
            // 
            this.btn_kp_musteri.Location = new System.Drawing.Point(23, 94);
            this.btn_kp_musteri.Name = "btn_kp_musteri";
            this.btn_kp_musteri.Size = new System.Drawing.Size(224, 48);
            this.btn_kp_musteri.TabIndex = 1;
            this.btn_kp_musteri.Text = "MÜŞTERİ EKLE/DÜZENLE";
            this.btn_kp_musteri.UseVisualStyleBackColor = true;
            this.btn_kp_musteri.Click += new System.EventHandler(this.btn_kp_musteri_Click);
            // 
            // btn_kp_arac
            // 
            this.btn_kp_arac.Location = new System.Drawing.Point(23, 26);
            this.btn_kp_arac.Name = "btn_kp_arac";
            this.btn_kp_arac.Size = new System.Drawing.Size(224, 48);
            this.btn_kp_arac.TabIndex = 2;
            this.btn_kp_arac.Text = "ARAÇ EKLE/DÜZENLE";
            this.btn_kp_arac.UseVisualStyleBackColor = true;
            this.btn_kp_arac.Click += new System.EventHandler(this.btn_kp_arac_Click);
            // 
            // btn_kp_silinenler
            // 
            this.btn_kp_silinenler.Location = new System.Drawing.Point(23, 227);
            this.btn_kp_silinenler.Name = "btn_kp_silinenler";
            this.btn_kp_silinenler.Size = new System.Drawing.Size(224, 48);
            this.btn_kp_silinenler.TabIndex = 3;
            this.btn_kp_silinenler.Text = "SİLİNEN KAYITLAR";
            this.btn_kp_silinenler.UseVisualStyleBackColor = true;
            this.btn_kp_silinenler.Click += new System.EventHandler(this.btn_kp_silinenler_Click);
            // 
            // KullaniciPaneliWF
            // 
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.btn_kp_silinenler);
            this.Controls.Add(this.btn_kp_arac);
            this.Controls.Add(this.btn_kp_musteri);
            this.Controls.Add(this.btn_kp_sözlesme);
            this.Name = "KullaniciPaneliWF";
            this.Text = "Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.KullaniciPaneliWF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_kp_sözlesme;
        private System.Windows.Forms.Button btn_kp_musteri;
        private System.Windows.Forms.Button btn_kp_arac;
        private System.Windows.Forms.Button btn_kp_silinenler;
    }
}