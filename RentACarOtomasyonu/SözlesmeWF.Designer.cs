namespace RentACarOtomasyonu
{
    partial class SözlesmeWF
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
            this.dtp_alimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_s_araba = new System.Windows.Forms.ComboBox();
            this.cmb_s_musteri = new System.Windows.Forms.ComboBox();
            this.btn_s_olustur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvw_s_aracbilgi = new System.Windows.Forms.DataGridView();
            this.dgvw_s_musteribilgi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_s_guncelle = new System.Windows.Forms.Button();
            this.btn_s_sil = new System.Windows.Forms.Button();
            this.cmb_s_aktifmi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblmusterisozlesme = new System.Windows.Forms.Label();
            this.dgvw_musterisozlesmeleri = new System.Windows.Forms.DataGridView();
            this.dgvw_mevcutsozlesmeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_s_aracbilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_s_musteribilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_musterisozlesmeleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_mevcutsozlesmeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Seçiniz";
            // 
            // dtp_alimtarihi
            // 
            this.dtp_alimtarihi.CustomFormat = "";
            this.dtp_alimtarihi.Location = new System.Drawing.Point(48, 200);
            this.dtp_alimtarihi.MinDate = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtp_alimtarihi.Name = "dtp_alimtarihi";
            this.dtp_alimtarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_alimtarihi.TabIndex = 2;
            this.dtp_alimtarihi.ValueChanged += new System.EventHandler(this.dtp_alimtarihi_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kiralanan Süre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toplam Fatura Tutari";
            // 
            // cmb_s_araba
            // 
            this.cmb_s_araba.FormattingEnabled = true;
            this.cmb_s_araba.Location = new System.Drawing.Point(322, 51);
            this.cmb_s_araba.Name = "cmb_s_araba";
            this.cmb_s_araba.Size = new System.Drawing.Size(121, 21);
            this.cmb_s_araba.TabIndex = 5;
            this.cmb_s_araba.SelectedIndexChanged += new System.EventHandler(this.cmb_s_araba_SelectedIndexChanged);
            // 
            // cmb_s_musteri
            // 
            this.cmb_s_musteri.FormattingEnabled = true;
            this.cmb_s_musteri.Location = new System.Drawing.Point(322, 140);
            this.cmb_s_musteri.Name = "cmb_s_musteri";
            this.cmb_s_musteri.Size = new System.Drawing.Size(121, 21);
            this.cmb_s_musteri.TabIndex = 6;
            this.cmb_s_musteri.SelectedIndexChanged += new System.EventHandler(this.cmb_s_musteri_SelectedIndexChanged);
            // 
            // btn_s_olustur
            // 
            this.btn_s_olustur.Location = new System.Drawing.Point(322, 404);
            this.btn_s_olustur.Name = "btn_s_olustur";
            this.btn_s_olustur.Size = new System.Drawing.Size(121, 44);
            this.btn_s_olustur.TabIndex = 7;
            this.btn_s_olustur.Text = "Sözleşme Oluştur";
            this.btn_s_olustur.UseVisualStyleBackColor = true;
            this.btn_s_olustur.Click += new System.EventHandler(this.btn_s_tamamla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seçilen Araç Özellikleri";
            // 
            // dgvw_s_aracbilgi
            // 
            this.dgvw_s_aracbilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_s_aracbilgi.Location = new System.Drawing.Point(466, 51);
            this.dgvw_s_aracbilgi.Name = "dgvw_s_aracbilgi";
            this.dgvw_s_aracbilgi.Size = new System.Drawing.Size(428, 62);
            this.dgvw_s_aracbilgi.TabIndex = 10;
            // 
            // dgvw_s_musteribilgi
            // 
            this.dgvw_s_musteribilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_s_musteribilgi.Location = new System.Drawing.Point(466, 140);
            this.dgvw_s_musteribilgi.Name = "dgvw_s_musteribilgi";
            this.dgvw_s_musteribilgi.Size = new System.Drawing.Size(428, 62);
            this.dgvw_s_musteribilgi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seçilen Müşteri Bilgileri";
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.Location = new System.Drawing.Point(319, 294);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(0, 13);
            this.lbl_sure.TabIndex = 13;
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(319, 326);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(0, 13);
            this.lbl_tutar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alım Tarihi Seçiniz";
            // 
            // dtp_teslimtarihi
            // 
            this.dtp_teslimtarihi.CustomFormat = "";
            this.dtp_teslimtarihi.Location = new System.Drawing.Point(48, 262);
            this.dtp_teslimtarihi.MinDate = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            this.dtp_teslimtarihi.Name = "dtp_teslimtarihi";
            this.dtp_teslimtarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_teslimtarihi.TabIndex = 16;
            this.dtp_teslimtarihi.ValueChanged += new System.EventHandler(this.dtp_teslimtarihi_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Teslim Tarihi Seçiniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gün";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mevcut Sözleşmeler";
            // 
            // btn_s_guncelle
            // 
            this.btn_s_guncelle.Location = new System.Drawing.Point(191, 404);
            this.btn_s_guncelle.Name = "btn_s_guncelle";
            this.btn_s_guncelle.Size = new System.Drawing.Size(125, 44);
            this.btn_s_guncelle.TabIndex = 23;
            this.btn_s_guncelle.Text = "Güncelle";
            this.btn_s_guncelle.UseVisualStyleBackColor = true;
            this.btn_s_guncelle.Click += new System.EventHandler(this.btn_s_guncelle_Click);
            // 
            // btn_s_sil
            // 
            this.btn_s_sil.Location = new System.Drawing.Point(48, 404);
            this.btn_s_sil.Name = "btn_s_sil";
            this.btn_s_sil.Size = new System.Drawing.Size(134, 44);
            this.btn_s_sil.TabIndex = 24;
            this.btn_s_sil.Text = "Sözleşme Sil";
            this.btn_s_sil.UseVisualStyleBackColor = true;
            this.btn_s_sil.Click += new System.EventHandler(this.btn_s_sil_Click);
            // 
            // cmb_s_aktifmi
            // 
            this.cmb_s_aktifmi.FormattingEnabled = true;
            this.cmb_s_aktifmi.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmb_s_aktifmi.Location = new System.Drawing.Point(317, 364);
            this.cmb_s_aktifmi.Name = "cmb_s_aktifmi";
            this.cmb_s_aktifmi.Size = new System.Drawing.Size(126, 21);
            this.cmb_s_aktifmi.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "AktifMi";
            // 
            // lblmusterisozlesme
            // 
            this.lblmusterisozlesme.AutoSize = true;
            this.lblmusterisozlesme.Location = new System.Drawing.Point(466, 224);
            this.lblmusterisozlesme.Name = "lblmusterisozlesme";
            this.lblmusterisozlesme.Size = new System.Drawing.Size(117, 13);
            this.lblmusterisozlesme.TabIndex = 29;
            this.lblmusterisozlesme.Text = "Mevcut Sözleşmeleriniz";
            // 
            // dgvw_musterisozlesmeleri
            // 
            this.dgvw_musterisozlesmeleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_musterisozlesmeleri.Location = new System.Drawing.Point(466, 241);
            this.dgvw_musterisozlesmeleri.Name = "dgvw_musterisozlesmeleri";
            this.dgvw_musterisozlesmeleri.Size = new System.Drawing.Size(428, 66);
            this.dgvw_musterisozlesmeleri.TabIndex = 30;
            // 
            // dgvw_mevcutsozlesmeler
            // 
            this.dgvw_mevcutsozlesmeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_mevcutsozlesmeler.Location = new System.Drawing.Point(466, 373);
            this.dgvw_mevcutsozlesmeler.Name = "dgvw_mevcutsozlesmeler";
            this.dgvw_mevcutsozlesmeler.Size = new System.Drawing.Size(428, 97);
            this.dgvw_mevcutsozlesmeler.TabIndex = 31;
            this.dgvw_mevcutsozlesmeler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvw_mevcutsozlesmeler_MouseClick);
            // 
            // SözlesmeWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 479);
            this.Controls.Add(this.dgvw_mevcutsozlesmeler);
            this.Controls.Add(this.dgvw_musterisozlesmeleri);
            this.Controls.Add(this.lblmusterisozlesme);
            this.Controls.Add(this.cmb_s_aktifmi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_s_sil);
            this.Controls.Add(this.btn_s_guncelle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_teslimtarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvw_s_musteribilgi);
            this.Controls.Add(this.dgvw_s_aracbilgi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_s_olustur);
            this.Controls.Add(this.cmb_s_musteri);
            this.Controls.Add(this.cmb_s_araba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_alimtarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SözlesmeWF";
            this.Text = "Araç Kiralama Paneli";
            this.Load += new System.EventHandler(this.SözlesmeWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_s_aracbilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_s_musteribilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_musterisozlesmeleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_mevcutsozlesmeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_alimtarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_s_araba;
        private System.Windows.Forms.ComboBox cmb_s_musteri;
        private System.Windows.Forms.Button btn_s_olustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvw_s_aracbilgi;
        private System.Windows.Forms.DataGridView dgvw_s_musteribilgi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_teslimtarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_s_aktifmi;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_s_guncelle;
        public System.Windows.Forms.Button btn_s_sil;
        private System.Windows.Forms.Label lblmusterisozlesme;
        private System.Windows.Forms.DataGridView dgvw_musterisozlesmeleri;
        private System.Windows.Forms.DataGridView dgvw_mevcutsozlesmeler;
    }
}