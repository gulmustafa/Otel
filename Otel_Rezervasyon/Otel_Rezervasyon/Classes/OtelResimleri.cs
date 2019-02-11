using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class OtelResimleri : DbObject
    {
        public OtelResimleri()
        {

        }
        public Otel Otel { get; set; }
        public byte[] Resim { get; set; }

        public override string ToString()
        {
            return "Resim" + Resim;
        }

    }
}
