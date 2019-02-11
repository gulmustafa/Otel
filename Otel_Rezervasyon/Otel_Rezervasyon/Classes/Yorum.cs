using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class Yorum : DbObject
    {
        public Yorum()
        {
            Yildiz = new List<Yildiz>();
        }
        public Musteri Musteri { get; set; }
        [MaxLength(100)]
        public string YorumBasligi { get; set; }
        [MaxLength(100)]
        public string YorumIcerigi { get; set; }
        public List<Yildiz> Yildiz { get; set; }

        public override string ToString()
        {
            return "Yorum" + Musteri;
        }


    }
}
