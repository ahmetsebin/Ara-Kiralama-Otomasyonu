using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Entity
{
  public  class SilinenMusteriler:BaseEntity
    {
        public int MusteriID { get; set; }
        
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TC { get; set; }

        public string EhliyetNo { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public string Adres { get; set; }

        public string Sifre { get; set; }
    }
}
