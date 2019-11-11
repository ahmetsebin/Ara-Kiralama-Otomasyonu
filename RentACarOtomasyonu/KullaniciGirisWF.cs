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
    public partial class KullaniciGirisWF : Form
    {
        public KullaniciGirisWF()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        public static string gonderilecekveri;  //formlar arası veri gönderme
        public static string musterikullaniciadi;
        private void btn_k_giris_Click(object sender, EventArgs e)
        {
           
            gonderilecekveri = txt_k_adi.Text;
            string ad = "";
            string sifre = "";
            string yetki = "";
            List<Kullanicilar> f = new List<Kullanicilar>();
            f = db.Kullanicilars.Where(x => x.KullaniciAdi == txt_k_adi.Text).ToList();
            foreach (Kullanicilar item in f)
            {
                ad = item.KullaniciAdi.ToString();
                sifre = item.Sifre.ToString();
                yetki = item.Yetki.ToString();
            }

            if (ad == txt_k_adi.Text)
            {
                if (sifre == txt_k_sifre.Text)
                {
                    if (yetki == "1")
                    {
                        KullaniciPaneliWF kp = new KullaniciPaneliWF();
                        kp.Show();
                        this.Hide();
                    }
                    else if (yetki == "2")
                    {
                        SözlesmeWF swf = new SözlesmeWF();
                        swf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yetkiniz yetersiz");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreniz Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Yok..");
            }
        }

        private void KullaniciGirisWF_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (db.Kullanicilars.Count() < 1)
            {
                Kullanicilar k1 = new Kullanicilar();
                k1.KullaniciAdi = "sebin";
                k1.Sifre = "2534";
                k1.Yetki = "1";

                db.Kullanicilars.Add(k1);
                db.SaveChanges();
                this.Hide();
            }
        }

        private void chcbx_kg_CheckedChanged(object sender, EventArgs e)
        {
            if(chcbx_kg.Checked)
            {
                txt_k_sifre.PasswordChar = '\0';
            }
            else
            {
                txt_k_sifre.PasswordChar = '*';
            }
        }
    }
}
