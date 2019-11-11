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
    public partial class KullaniciPaneliWF : Form
    {
        public KullaniciPaneliWF()
        {
            InitializeComponent();
        }

        private void btn_kp_arac_Click(object sender, EventArgs e)
        {
            ArabaWF awf = new ArabaWF();
            awf.Show();
          
        }

        private void btn_kp_musteri_Click(object sender, EventArgs e)
        {
            Form1 mwf = new Form1();
            mwf.Show();
            
        }

        private void KullaniciPaneliWF_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btn_kp_sözlesme_Click(object sender, EventArgs e)
        {
            SözlesmeWF swf = new SözlesmeWF();
            swf.Show();
        }

        private void btn_kp_silinenler_Click(object sender, EventArgs e)
        {
            SilinenKayitlarWF skwf = new SilinenKayitlarWF();
            skwf.Show();
        }
    }
}
