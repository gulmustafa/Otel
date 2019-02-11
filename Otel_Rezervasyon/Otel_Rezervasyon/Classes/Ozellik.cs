using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class Ozellik:DbObject
    {
        public Ozellik()
        {

        }
        public string OzellikAdi { get; set; }

        public override string ToString()
        {
            return "Özellik" + OzellikAdi;
        }


    }
}
