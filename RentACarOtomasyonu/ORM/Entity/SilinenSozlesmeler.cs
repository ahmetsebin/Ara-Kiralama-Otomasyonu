using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Entity
{
  public  class SilinenSozlesmeler:BaseEntity
    {
        public int ArabaID { get; set; }

        public int MusteriID { get; set; }

        public DateTime AlisTarihi { get; set; }

        public DateTime TeslimTarihi { get; set; }

        public int KiralanmaSuresi { get; set; }

        public decimal FaturaTutari { get; set; }
    }
}
