namespace RentACarOtomasyonu
{
    partial class SilinenKayitlarWF
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
            this.dgvw_silinenarabalar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvw_silinenmusteriler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvw_silinensozlesmeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_silinenarabalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_silinenmusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_silinensozlesmeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvw_silinenarabalar
            // 
            this.dgvw_silinenarabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_silinenarabalar.Location = new System.Drawing.Point(40, 34);
            this.dgvw_silinenarabalar.Name = "dgvw_silinenarabalar";
            this.dgvw_silinenarabalar.Size = new System.Drawing.Size(724, 97);
            this.dgvw_silinenarabalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLİNEN ARAÇ KAYITLARI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SİLİNEN MÜŞTERİ KAYITLARI";
            // 
            // dgvw_silinenmusteriler
            // 
            this.dgvw_silinenmusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_silinenmusteriler.Location = new System.Drawing.Point(40, 178);
            this.dgvw_silinenmusteriler.Name = "dgvw_silinenmusteriler";
            this.dgvw_silinenmusteriler.Size = new System.Drawing.Size(724, 97);
            this.dgvw_silinenmusteriler.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SİLİNEN KİRALAMA KAYITLARI";
            // 
            // dgvw_silinensozlesmeler
            // 
            this.dgvw_silinensozlesmeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_silinensozlesmeler.Location = new System.Drawing.Point(40, 324);
            this.dgvw_silinensozlesmeler.Name = "dgvw_silinensozlesmeler";
            this.dgvw_silinensozlesmeler.Size = new System.Drawing.Size(724, 97);
            this.dgvw_silinensozlesmeler.TabIndex = 5;
            // 
            // SilinenKayitlarWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvw_silinensozlesmeler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvw_silinenmusteriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvw_silinenarabalar);
            this.Name = "SilinenKayitlarWF";
            this.Text = "Silinen Kayıtlar";
            this.Load += new System.EventHandler(this.SilinenKayitlarWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_silinenarabalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_silinenmusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_silinensozlesmeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvw_silinenarabalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvw_silinenmusteriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvw_silinensozlesmeler;
    }
}