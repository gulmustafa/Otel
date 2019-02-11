using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class Otel:DbObject
    {
        public Otel()
        {
            Yorumlar = new List<Yorum>();
            Yildizlar = new List<Yildiz>();
        }
        [MaxLength(100)]
        public string Adi { get; set; }
        public İl Adresi { get; set; }
        public string VergiNo { get; set; }
        [MaxLength(100)]
        public string ResmiAdi { get; set; }
        public string Aciklama { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Yildiz> Yildizlar { get; set; }


        public override string ToString()
        {
            return "Otel" + Adi;
        }

    }

    


}
