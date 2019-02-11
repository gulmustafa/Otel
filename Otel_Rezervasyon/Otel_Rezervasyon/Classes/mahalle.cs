using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class Mahalle : DbObject
    {
        public Mahalle()
        {

        }
        [MaxLength(100)]

        public string MahalleAdi { get; set; }

        public override string ToString()
        {
            return "Mahalle" + MahalleAdi;
        }
    }
}
