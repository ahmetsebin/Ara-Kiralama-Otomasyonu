using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Entity
{
    public class Musteriler:BaseEntity
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string TC { get; set; }
        [Required]
        public string EhliyetNo { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Sifre { get; set; }
        //Mapping
        //List<Arabalar> Cars { get; set; }
        List<Kiralama> Kiralamas { get; set; }
    }
}
