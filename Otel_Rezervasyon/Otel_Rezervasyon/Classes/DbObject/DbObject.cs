using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    
    public abstract class DbObject
    {
        public string Id { get; set; }
        [MaxLength(50)]
        public string OlusturanKisi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        [MaxLength(50)]
        public string GuncelleyenKisi { get; set; }

        public DbObject()
        {
            Id = Guid.NewGuid().ToString();
            OlusturmaTarihi = DateTime.Now;
            OlusturanKisi = "Emre";
            GuncelleyenKisi = "Sezer";
            GuncellemeTarihi = DateTime.Now;
        }
    }
}
