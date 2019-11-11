using RentACarOtomasyonu.ORM.Context;
using RentACarOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarOtomasyonu
{
    public partial class SözlesmeWF : Form
    {

        public string tc = "";
        public string yetki = "";
        public SözlesmeWF()
        {
            InitializeComponent();
            List<Kullanicilar> k = new List<Kullanicilar>();         
            string kadi = KullaniciGirisWF.gonderilecekveri;  //diğer formdan gelen veri
            k = db.Kullanicilars.Where(x => x.KullaniciAdi == kadi.ToString()).ToList();           
            foreach (Kullanicilar item in k)
            {
                yetki = item.Yetki.ToString();
            }
            if (yetki == "2")
            {
                //lstvw_s_sozlesmeler.Hide();
                btn_s_guncelle.Hide();
                btn_s_sil.Hide();
                label11.Hide();
                dgvw_mevcutsozlesmeler.Hide();
                List<Musteriler> mlr = new List<Musteriler>();
                mlr = db.Customers.Where(x => x.TC == kadi.ToString()).ToList();
                foreach (Musteriler item in mlr)
                {
                    tc = item.TC.ToString();
                }
            }
            else
            {
                lblmusterisozlesme.Hide();
                dgvw_musterisozlesmeleri.Hide();
            }
        }

        ProjectContext db = new ProjectContext();
        List<DateTime> list = new List<DateTime>();
        public void KontrolEt()
        {
            List<Kiralama> krl = new List<Kiralama>();
            krl = db.Kiralamas.Where(x => x.AktifMi == true).ToList();

            foreach (Kiralama item in krl)
            {
                DateTime start = new DateTime();
                start = item.AlisTarihi;
                DateTime end = new DateTime();
                end = item.TeslimTarihi;

                var dates = new List<DateTime>();
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);
                    list.Add(dt);
                }
            }
        }
        List<DateTime> secilentariharalıgı = new List<DateTime>();
        public bool GonderilenKontrol(DateTime AlisTarihi, DateTime TeslimTarihi)
        {
            DateTime start = new DateTime();
            start = AlisTarihi;
            DateTime end = new DateTime();
            end = TeslimTarihi;
            var dates = new List<DateTime>();
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                dates.Add(dt);

                secilentariharalıgı.Add(dt);
            }
            for (int i = 0; i < dates.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (dates[i].ToString() == list[j].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btn_s_tamamla_Click(object sender, EventArgs e)
        {           
            bool a = GonderilenKontrol(dtp_alimtarihi.Value.Date, dtp_teslimtarihi.Value.Date);
            if (a == false)
            {
                MessageBox.Show("İstediğiniz Tarihte Araba Dolu Olduğundan Veremiyoruz.");
            }
            else
            {
                //TimeSpan fark = dtp_teslimtarihi.Value - dtp_alimtarihi.Value;  diğer kullanım
                TimeSpan GunFarki = dtp_teslimtarihi.Value.Subtract(dtp_alimtarihi.Value);
                int saraba;
                saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);
                int smusteri;
                smusteri = Convert.ToInt32(cmb_s_musteri.SelectedValue);
                int b = Convert.ToInt32(GunFarki.Days);
                List<Arabalar> arabalars = new List<Arabalar>();
                arabalars = db.Cars.Where(x => x.ID == saraba).ToList();
                foreach (Arabalar item in arabalars)
                {
                    arabafiyat = item.Fiyat;
                }
                Kiralama kiralama = new Kiralama();
                kiralama.ArabaID = saraba;
                kiralama.MusteriID = smusteri;
                kiralama.AlisTarihi = Convert.ToDateTime(dtp_alimtarihi.Value.Date);
                kiralama.TeslimTarihi = Convert.ToDateTime(dtp_teslimtarihi.Value.Date);
                kiralama.KiralanmaSuresi = Convert.ToInt32(GunFarki.Days.ToString());
                kiralama.FaturaTutari = Convert.ToDecimal((b * arabafiyat).ToString());
                kiralama.AddDate = DateTime.Now;
                kiralama.AktifMi = Convert.ToBoolean(cmb_s_aktifmi.SelectedIndex);
                db.Kiralamas.Add(kiralama);
                db.SaveChanges();
                MessageBox.Show("Sözleşme oluşturuldu");
            }
           
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Yeni Kayıt eklemek ister misiniz?", "Çıkmak için Hayıra basınız", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cancel == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                KontrolEt();
                dtp_alimtarihi.CustomFormat = " ";
                dtp_teslimtarihi.CustomFormat = " ";
            }
            cmb_s_aktifmi.SelectedIndex = -1;
            cmb_s_araba.SelectedIndex = -1;
            cmb_s_musteri.SelectedIndex = -1;
            dtp_alimtarihi.Text = string.Empty;
            dtp_teslimtarihi.Text = string.Empty;
            lbl_sure.Text = string.Empty;
            lbl_tutar.Text = string.Empty;
            //SozlesmeList();
            SozlesmeListDataGrid();
        }


        //public void SozlesmeList()
        //{
        //    lstvw_s_sozlesmeler.Items.Clear();
        //    foreach (Kiralama item in db.Kiralamas.ToList())
        //    {
        //        ListViewItem lvi = new ListViewItem();
        //        lvi.Text = item.ID.ToString();
        //        lvi.SubItems.Add(item.ArabaID.ToString());
        //        lvi.SubItems.Add(item.MusteriID.ToString());
        //        lvi.SubItems.Add(item.AlisTarihi.ToString());
        //        lvi.SubItems.Add(item.TeslimTarihi.ToString());
        //        lvi.SubItems.Add(item.KiralanmaSuresi.ToString());
        //        lvi.SubItems.Add(item.FaturaTutari.ToString());
        //        lvi.SubItems.Add(item.AddDate.ToString());
        //        lvi.SubItems.Add(item.UpdateDate.ToString());
        //        lvi.SubItems.Add(item.DeleteDate.ToString());
        //        lvi.SubItems.Add(item.AktifMi.ToString());               
        //        lvi.Tag = item.ID; //etiket
        //        lstvw_s_sozlesmeler.Items.Add(lvi);
        //    }
        //}

        private void SözlesmeWF_Load(object sender, EventArgs e)
        {
            KontrolEt();
            CarList();
            CustomerList();
            //SozlesmeList();
            CenterToScreen();
            SozlesmeListDataGrid();
        }
        public void CarList()
        {

            cmb_s_araba.DisplayMember = "Marka";
            cmb_s_araba.ValueMember = "ID";
            cmb_s_araba.DataSource = db.Cars.Where(x => x.AktifMi == true).ToList();
            cmb_s_araba.SelectedIndex = -1;
        }
        public void CustomerList()
        {

            cmb_s_musteri.DisplayMember = "Ad";
            cmb_s_musteri.ValueMember = "ID";
            if (yetki == "2")
            {
                cmb_s_musteri.DataSource = db.Customers.Where(x => x.AktifMi == true && x.TC == tc).ToList();
            }
            else
            {
                cmb_s_musteri.DataSource = db.Customers.Where(x => x.AktifMi == true).ToList();
            }
            cmb_s_musteri.SelectedIndex = -1;
        }
        private void cmb_s_araba_SelectedIndexChanged(object sender, EventArgs e)
        {

            int saraba;
            saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);
            dgvw_s_aracbilgi.DataSource = db.Cars.Where(x => x.ID == saraba).ToList();
        }

        private void cmb_s_musteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int smusteri;
            smusteri = Convert.ToInt32(cmb_s_musteri.SelectedValue);
            dgvw_s_musteribilgi.DataSource = db.Customers.Where(x => x.ID == smusteri).ToList();

            if (yetki == "2")          //Join kullanımı
            {
                var joinResult = (from c in db.Customers
                                  from k in db.Kiralamas
                                  from m in db.Cars
                                  where c.ID == k.MusteriID && k.ArabaID == m.ID
                                  select new
                                  {
                                      c.Ad,
                                      c.Soyad,
                                      c.TC,
                                      c.Telefon,
                                      m.Marka,
                                      m.Model,
                                      m.Plaka,
                                      k.AlisTarihi,
                                      k.TeslimTarihi,
                                      k.KiralanmaSuresi
                                  }).ToList();
                dgvw_musterisozlesmeleri.DataSource = joinResult.Where(x => x.TC == tc).ToList();
            }
        }

        Kiralama updated;

        //private void lstvw_s_sozlesmeler_DoubleClick(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(lstvw_s_sozlesmeler.SelectedItems[0].Tag);
        //    updated = db.Kiralamas.Find(id);
        //    cmb_s_araba.Text = updated.ArabaID.ToString();
        //    cmb_s_musteri.Text = updated.MusteriID.ToString();
        //    dtp_alimtarihi.Text = updated.AlisTarihi.ToString();
        //    dtp_teslimtarihi.Text = updated.TeslimTarihi.ToString();
        //    cmb_s_aktifmi.SelectedIndex = Convert.ToInt32(updated.AktifMi);

        //}

        private void btn_s_guncelle_Click(object sender, EventArgs e)
        {
            //if (lstvw_s_sozlesmeler.SelectedItems.Count <= 0 && updated == null)
            //    return;
            if (dgvw_mevcutsozlesmeler.SelectedRows.Count <= 0 && updated == null)
                return;
            TimeSpan fark = dtp_teslimtarihi.Value - dtp_alimtarihi.Value;
            int saraba;
            saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);
            int smusteri;
            smusteri = Convert.ToInt32(cmb_s_musteri.SelectedValue);
            int b = Convert.ToInt32(fark.Days);
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Cars.Where(x => x.ID == saraba).ToList();
            foreach (Arabalar item in arabalars)
            {
                arabafiyat = item.Fiyat;
            }
            updated.ArabaID = saraba;
            updated.MusteriID = smusteri;
            updated.AlisTarihi = Convert.ToDateTime(dtp_alimtarihi.Text);
            updated.TeslimTarihi = Convert.ToDateTime(dtp_teslimtarihi.Text);
            updated.KiralanmaSuresi = Convert.ToInt32(fark.Days.ToString());
            updated.FaturaTutari = Convert.ToDecimal((b * arabafiyat).ToString());
            updated.UpdateDate = DateTime.Now;
            updated.AktifMi = Convert.ToBoolean(cmb_s_aktifmi.SelectedIndex);
            db.Entry(db.Kiralamas.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            cmb_s_aktifmi.SelectedIndex = -1;
            cmb_s_araba.SelectedIndex = -1;
            cmb_s_musteri.SelectedIndex = -1;
            dtp_alimtarihi.Text = string.Empty;
            dtp_teslimtarihi.Text = string.Empty;
            lbl_sure.Text = string.Empty;
            lbl_tutar.Text = string.Empty;
            //SozlesmeList();
            SozlesmeListDataGrid();
        }      
        private void btn_s_sil_Click(object sender, EventArgs e)
        {
            //if (lstvw_s_sozlesmeler.SelectedItems.Count <= 0)
            //    return;
            //int id = Convert.ToInt32(lstvw_s_sozlesmeler.SelectedItems[0].Tag);
            int id = Convert.ToInt32(dgvw_mevcutsozlesmeler.CurrentRow.Cells["ID"].Value.ToString());
            Kiralama deleted = db.Kiralamas.Find(id);

            SilinenSozlesmeler deletedsozlesme = new SilinenSozlesmeler();
            DialogResult nodelete = new DialogResult();
            nodelete = MessageBox.Show("Kaydı silmek istedğinize emin misiniz?", "Bak siliyorsun dikkat et!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (nodelete == DialogResult.Yes)
            {
                deletedsozlesme.ArabaID = Convert.ToInt32(cmb_s_musteri.SelectedValue);
                deletedsozlesme.MusteriID = Convert.ToInt32(cmb_s_araba.SelectedValue);
                deletedsozlesme.AlisTarihi = Convert.ToDateTime(dtp_alimtarihi.Text);
                deletedsozlesme.TeslimTarihi = Convert.ToDateTime(dtp_teslimtarihi.Value);
                TimeSpan GunFarki = dtp_teslimtarihi.Value.Subtract(dtp_alimtarihi.Value);
                int saraba;
                saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);
                dgvw_s_aracbilgi.DataSource = db.Cars.Where(x => x.ID == saraba).ToList();
                int smusteri;
                smusteri = Convert.ToInt32(cmb_s_musteri.SelectedValue);
                dgvw_s_musteribilgi.DataSource = db.Customers.Where(x => x.ID == smusteri).ToList();
                int b = Convert.ToInt32(GunFarki.Days);
                int c = Convert.ToInt32(db.Cars.Where(x => x.ID == saraba).Sum(x => x.Fiyat));
                deletedsozlesme.KiralanmaSuresi = Convert.ToInt32(GunFarki.Days.ToString());
                deletedsozlesme.FaturaTutari = Convert.ToDecimal((b * c).ToString());
                deletedsozlesme.AddDate = updated.AddDate;
                deletedsozlesme.UpdateDate = updated.UpdateDate;
                deletedsozlesme.DeleteDate = DateTime.Now;
                deletedsozlesme.AktifMi = Convert.ToBoolean(cmb_s_aktifmi.SelectedIndex);
                deletedsozlesme.DeleteDate = DateTime.Now;
                deletedsozlesme.AddDate = updated.AddDate;
                deletedsozlesme.UpdateDate = updated.UpdateDate;
                db.SilinenSozlesmelers.Add(deletedsozlesme);
                db.Kiralamas.Remove(deleted);
                db.SaveChanges();
            }
            cmb_s_aktifmi.SelectedIndex = -1;
            cmb_s_araba.SelectedIndex = -1;
            cmb_s_musteri.SelectedIndex = -1;
            dtp_alimtarihi.Text = string.Empty;
            dtp_teslimtarihi.Text = string.Empty;
            lbl_sure.Text = string.Empty;
            lbl_tutar.Text = string.Empty;
            //SozlesmeList();
            SozlesmeListDataGrid();
        }

        private void dtp_alimtarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimtarihi.Enabled = true;
        }
        public decimal arabafiyat;

        private void dtp_teslimtarihi_ValueChanged(object sender, EventArgs e)
        {
            int saraba;
            saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);
            TimeSpan GunFarki = dtp_teslimtarihi.Value.Subtract(dtp_alimtarihi.Value);
            int b = Convert.ToInt32(GunFarki.Days);
            //int c = Convert.ToInt32(db.Cars.Where(x => x.ID == saraba).Sum(x => x.Fiyat));
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Cars.Where(x => x.ID == saraba).ToList();
            foreach (Arabalar item in arabalars)
            {
                arabafiyat = item.Fiyat;
            }
            if (Convert.ToDecimal((b * arabafiyat).ToString()) <= 0 && Convert.ToInt32(GunFarki.Days.ToString()) <= 0)
            {
                MessageBox.Show("Teslim Tarihi Alış Tarihinden önce olamaz Lütfen Düzeltiniz!!");
            }
            else
            {
                lbl_tutar.Text = (b * arabafiyat).ToString();
                lbl_sure.Text = GunFarki.Days.ToString();
            }
        }


        public void SozlesmeListDataGrid()
        {                                       
                dgvw_mevcutsozlesmeler.DataSource = db.Kiralamas.Where(x=>x.AktifMi==true).ToList();
                          
        }

        private void dgvw_mevcutsozlesmeler_MouseClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvw_mevcutsozlesmeler.CurrentRow.Cells["ID"].Value.ToString());
            updated = db.Kiralamas.Find(id);
            cmb_s_araba.Text = updated.Araba.Marka.ToString();
            cmb_s_musteri.Text = updated.Musteri.Ad.ToString();
            dtp_alimtarihi.Text = updated.AlisTarihi.ToString();
            dtp_teslimtarihi.Text = updated.TeslimTarihi.ToString();
            cmb_s_aktifmi.SelectedIndex = Convert.ToInt32(updated.AktifMi);
            MessageBox.Show("Güncelleme Yapmak için Bütün Alanları seçiniz");
        }
    }
}
