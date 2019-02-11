using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
   public class Rezervasyon:DbObject
    {
        public Rezervasyon()
        {

        }
        public Musteri Musteri { get; set; }
        public Oda Oda { get; set; }
        public string KisiSayisi { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public enumOdemeZamani OdemeZamani { get; set; }

        public override string ToString()
        {
            return "Rezervasyon Bilgileri" + Musteri + " " + CheckDate + " "+ CheckOutDate;
        }


    }
}
