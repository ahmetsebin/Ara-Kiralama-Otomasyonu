using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarOtomasyonu.ORM.Entity
{
    public class Arabalar:BaseEntity
    {
        [Required]
        public string Plaka { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string AracTipi { get; set; }
        [Required]
        public string Vites { get; set; }
        [Required]
        public string YakitTipi { get; set; }
        [Required]
        public decimal Fiyat { get; set; }

        //Mapping
        //List<Musteriler> Customers { get; set; }
        List<Kiralama> Kiralamas { get; set; }
    }
}
