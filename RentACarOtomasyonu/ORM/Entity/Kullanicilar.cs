using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Entity
{
     public class Kullanicilar
    {
        [Key]
        public int KullaniciID { get; set; }
        
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}
