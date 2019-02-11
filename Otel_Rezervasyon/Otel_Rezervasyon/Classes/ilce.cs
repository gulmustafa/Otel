using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class İlce : DbObject
    {
        public İlce()
        {
            Mahalleler = new List<Mahalle>();
        }
        [MaxLength(100)]
        public string İlceAdi { get; set; }
        public List<Mahalle> Mahalleler { get; set; }

        public override string ToString()
        {
            return "İlçe" + İlceAdi;
        }
    }
}
