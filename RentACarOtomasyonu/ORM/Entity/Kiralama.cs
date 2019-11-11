using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Entity
{
    public class Kiralama:BaseEntity
    {
        public int ArabaID { get; set; }
        [ForeignKey("ArabaID")]
        public Arabalar Araba { get; set; }
        public int MusteriID { get; set; }
        [ForeignKey("MusteriID")]
        public Musteriler Musteri { get; set; }
        [Required]
        public DateTime AlisTarihi { get; set; }
        [Required]
        public DateTime TeslimTarihi { get; set; }
        [Required]
        public int KiralanmaSuresi { get;set; }
        [Required]
        public decimal FaturaTutari { get; set; }
        
    }
}
