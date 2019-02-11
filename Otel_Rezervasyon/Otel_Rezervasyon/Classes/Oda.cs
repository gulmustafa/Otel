using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
   public class Oda:DbObject
    {
        public Oda()
        {
           
        }

        public Otel Otel { get; set; }
        public double Ucret { get; set; }
        public enumOdaTipi odaTipi { get; set; }
        public bool BosMu { get; set; }
        [MaxLength(20)]
        public string OdaNo { get; set; }

        public override string ToString()
        {
            return "Oda" + OdaNo;
        }
    }
}
