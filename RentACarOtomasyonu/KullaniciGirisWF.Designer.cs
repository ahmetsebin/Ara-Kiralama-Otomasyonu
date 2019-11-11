namespace RentACarOtomasyonu
{
    partial class KullaniciGirisWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_k_adi = new System.Windows.Forms.TextBox();
            this.txt_k_sifre = new System.Windows.Forms.TextBox();
            this.btn_k_giris = new System.Windows.Forms.Button();
            this.chcbx_kg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txt_k_adi
            // 
            this.txt_k_adi.Location = new System.Drawing.Point(165, 51);
            this.txt_k_adi.Name = "txt_k_adi";
            this.txt_k_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_k_adi.TabIndex = 2;
            // 
            // txt_k_sifre
            // 
            this.txt_k_sifre.Location = new System.Drawing.Point(165, 95);
            this.txt_k_sifre.Name = "txt_k_sifre";
            this.txt_k_sifre.PasswordChar = '*';
            this.txt_k_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_k_sifre.TabIndex = 3;
            // 
            // btn_k_giris
            // 
            this.btn_k_giris.Location = new System.Drawing.Point(165, 142);
            this.btn_k_giris.Name = "btn_k_giris";
            this.btn_k_giris.Size = new System.Drawing.Size(100, 23);
            this.btn_k_giris.TabIndex = 4;
            this.btn_k_giris.Text = "Giriş";
            this.btn_k_giris.UseVisualStyleBackColor = true;
            this.btn_k_giris.Click += new System.EventHandler(this.btn_k_giris_Click);
            // 
            // chcbx_kg
            // 
            this.chcbx_kg.AutoSize = true;
            this.chcbx_kg.Location = new System.Drawing.Point(165, 119);
            this.chcbx_kg.Name = "chcbx_kg";
            this.chcbx_kg.Size = new System.Drawing.Size(81, 17);
            this.chcbx_kg.TabIndex = 5;
            this.chcbx_kg.Text = "Şifre Göster";
            this.chcbx_kg.UseVisualStyleBackColor = true;
            this.chcbx_kg.CheckedChanged += new System.EventHandler(this.chcbx_kg_CheckedChanged);
            // 
            // KullaniciGirisWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 339);
            this.Controls.Add(this.chcbx_kg);
            this.Controls.Add(this.btn_k_giris);
            this.Controls.Add(this.txt_k_sifre);
            this.Controls.Add(this.txt_k_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGirisWF";
            this.Text = "Kullanıcı Giriş Ekranı";
            this.Load += new System.EventHandler(this.KullaniciGirisWF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_k_giris;
        public System.Windows.Forms.TextBox txt_k_adi;
        public System.Windows.Forms.TextBox txt_k_sifre;
        private System.Windows.Forms.CheckBox chcbx_kg;
    }
}