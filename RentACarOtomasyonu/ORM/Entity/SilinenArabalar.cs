using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Entity
{
   public class SilinenArabalar:BaseEntity
    {
        public int ArabaID { get; set; }

        public string Plaka { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public string AracTipi { get; set; }

        public string Vites { get; set; }

        public string YakitTipi { get; set; }
 
        public decimal Fiyat { get; set; }
    }
}
