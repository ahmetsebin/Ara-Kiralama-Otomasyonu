using RentACarOtomasyonu.ORM.Context;
using RentACarOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        private void btn_m_ekle_Click(object sender, EventArgs e)
        {
            Button btndzn = new Button();
            btndzn.Visible = true;
            this.Controls.Add(btndzn);
            Kullanicilar kullanici = new Kullanicilar();
            Musteriler musteri = new Musteriler();
            musteri.Ad = txt_m_isim.Text;
            musteri.Soyad = txt_m_soyisim.Text;
            musteri.TC = txt_m_tc.Text;
            musteri.EhliyetNo = txt_m_ehliyet.Text;
            musteri.Telefon = txt_m_telefon.Text;
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!reg.IsMatch(txt_m_email.Text))
            {
                MessageBox.Show("Geçersiz Mail Adresi");
                return;
            }
            else
            {
                musteri.Email = txt_m_email.Text;
            }            
            musteri.Adres = txt_m_adres.Text;
            musteri.Sifre = txt_m_sifre.Text;           
            musteri.AddDate = DateTime.Now;
            musteri.AktifMi = Convert.ToBoolean(cmb_m_aktifmi.SelectedIndex);
            kullanici.KullaniciAdi = txt_m_tc.Text;
            kullanici.Yetki = "2";
            kullanici.Sifre = txt_m_sifre.Text;
            db.Kullanicilars.Add(kullanici);
            db.Customers.Add(musteri);            
            db.SaveChanges();
            MessageBox.Show("Müşteri kaydı eklendi");
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Yeni Kayıt eklemek ister misiniz?", "Çıkmak için Hayıra basınız", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cancel == DialogResult.No)
            {
                this.Close();
            }
            cmb_m_aktifmi.SelectedIndex = -1;
            txt_m_isim.Text = string.Empty;
            txt_m_soyisim.Text= default(string);
            txt_m_tc.Text = default(string);
            txt_m_ehliyet.Text = string.Empty;
            txt_m_telefon.Text = string.Empty;
            txt_m_email.Text = string.Empty;
            txt_m_adres.Text = string.Empty;
            txt_m_sifre.Text = string.Empty;
            CustomerList();
        }
        public void CustomerList()
        {
            lstvw_m_bilgi.Items.Clear();
            foreach (Musteriler item in db.Customers.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Soyad);
                lvi.SubItems.Add(item.TC);
                lvi.SubItems.Add(item.EhliyetNo);
                lvi.SubItems.Add(item.Telefon);
                lvi.SubItems.Add(item.Email);
                lvi.SubItems.Add(item.Adres);
                lvi.SubItems.Add(item.Sifre);
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.SubItems.Add(item.UpdateDate.ToString());
                lvi.SubItems.Add(item.DeleteDate.ToString());
                lvi.SubItems.Add(item.AktifMi.ToString());
                lvi.Tag = item.ID; //etiket
                lstvw_m_bilgi.Items.Add(lvi);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerList();
            CenterToScreen();
        }

        Musteriler updated;
        private void btn_m_duzenle_Click(object sender, EventArgs e)
        {
            if (lstvw_m_bilgi.SelectedItems.Count <= 0 && updated == null)
                return;
            updated.Ad = txt_m_isim.Text;
            updated.Soyad = txt_m_soyisim.Text;
            updated.TC = txt_m_tc.Text;
            updated.EhliyetNo = txt_m_ehliyet.Text;
            updated.Telefon = txt_m_telefon.Text;
            updated.Email = txt_m_email.Text;
            updated.Adres = txt_m_adres.Text;
            updated.Sifre = txt_m_adres.Text;
            updated.UpdateDate = DateTime.Now;
            updated.AktifMi = Convert.ToBoolean(cmb_m_aktifmi.SelectedIndex);

            db.Entry(db.Customers.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();

            cmb_m_aktifmi.SelectedIndex = -1;
            txt_m_isim.Text = string.Empty;
            txt_m_soyisim.Text = default(string);
            txt_m_tc.Text = default(string);
            txt_m_ehliyet.Text = string.Empty;
            txt_m_telefon.Text = string.Empty;
            txt_m_email.Text = string.Empty;
            txt_m_adres.Text = string.Empty;
            txt_m_sifre.Text = string.Empty;

            CustomerList();
        }

        private void lstvw_m_bilgi_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstvw_m_bilgi.SelectedItems[0].Tag);
            updated = db.Customers.Find(id);
            txt_m_isim.Text = updated.Ad;
            txt_m_soyisim.Text = updated.Soyad;
            txt_m_tc.Text=updated.TC;
            txt_m_ehliyet.Text = updated.EhliyetNo;
            txt_m_telefon.Text = updated.Telefon;
            txt_m_email.Text = updated.Email;
            txt_m_adres.Text = updated.Adres;
            txt_m_sifre.Text = updated.Sifre;
            cmb_m_aktifmi.SelectedIndex=Convert.ToInt32(updated.AktifMi);
        }

        private void btn_m_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_m_bilgi.SelectedItems.Count <= 0)
                return;
            int id = Convert.ToInt32(lstvw_m_bilgi.SelectedItems[0].Tag);
            Musteriler deleted = db.Customers.Find(id);
            SilinenMusteriler deletedmusteri = new SilinenMusteriler();
            DialogResult nodelete = new DialogResult();
            nodelete = MessageBox.Show("Kaydı silmek istedğinize emin misiniz?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (nodelete == DialogResult.Yes)
            {
                deletedmusteri.MusteriID = updated.ID;
                deletedmusteri.Ad = txt_m_isim.Text;
                deletedmusteri.Soyad = txt_m_soyisim.Text;
                deletedmusteri.TC = txt_m_tc.Text;
                deletedmusteri.EhliyetNo = txt_m_ehliyet.Text;
                deletedmusteri.Telefon = txt_m_telefon.Text;
                deletedmusteri.Email = txt_m_email.Text;
                deletedmusteri.Adres = txt_m_adres.Text;
                deletedmusteri.Sifre = txt_m_sifre.Text;
                deletedmusteri.AktifMi = Convert.ToBoolean(cmb_m_aktifmi.SelectedIndex);
                deletedmusteri.DeleteDate = DateTime.Now;
                deletedmusteri.AddDate = updated.AddDate;
                deletedmusteri.UpdateDate = updated.UpdateDate;
                db.SilinenMusterilers.Add(deletedmusteri);
                db.Customers.Remove(deleted);
                db.SaveChanges();
            }

            //textbox ve comboboxları temizleme
            cmb_m_aktifmi.SelectedIndex = -1;
            txt_m_isim.Text = string.Empty;
            txt_m_soyisim.Text = default(string);
            txt_m_tc.Text = default(string);
            txt_m_ehliyet.Text = string.Empty;
            txt_m_telefon.Text = string.Empty;
            txt_m_email.Text = string.Empty;
            txt_m_adres.Text = string.Empty;
            txt_m_sifre.Text = string.Empty;
            CustomerList();
        }
    }
}
