using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    [Table("İller")]
    public class İl:DbObject
    {
        public İl()
        {
            İlceler = new List<İlce>();
        }
        [MaxLength(100)]
        public string İlAdi { get; set; }
        public List<İlce> İlceler { get; set; }

        public override string ToString()
        {
            return "İl" + İlAdi;
        }
    }
}
