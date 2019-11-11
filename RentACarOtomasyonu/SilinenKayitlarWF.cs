using RentACarOtomasyonu.ORM.Context;
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
    public partial class SilinenKayitlarWF : Form
    {
        public SilinenKayitlarWF()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void SilinenKayitlarWF_Load(object sender, EventArgs e)
        {
            dgvw_silinenarabalar.DataSource = db.SilinenArabalars.ToList();
            dgvw_silinenmusteriler.DataSource = db.SilinenMusterilers.ToList();
            dgvw_silinensozlesmeler.DataSource = db.SilinenSozlesmelers.ToList();
        }
    }
}
