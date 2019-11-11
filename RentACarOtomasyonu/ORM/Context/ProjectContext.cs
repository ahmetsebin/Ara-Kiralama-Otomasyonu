using RentACarOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarOtomasyonu.ORM.Context
{
  public  class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=101-16;Database=RentACarDENEME2;uid=sa;pwd=1234";
        }
        public DbSet<Arabalar> Cars { get; set; }
        public DbSet<Musteriler> Customers { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<SilinenArabalar> SilinenArabalars { get; set; }
        public DbSet<SilinenMusteriler> SilinenMusterilers { get; set; }
        public DbSet<SilinenSozlesmeler> SilinenSozlesmelers { get; set; }
    }
}
